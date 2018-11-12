using System;
using System.Data;
using System.Linq;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace UA3REO_Sweep_Analyzer
{
    public partial class mainForm : Form
    {
        private string title = "UA3REO Sweep Analyzer 0.1";

        private int startFreq = 0;
        private int endFreq = 0;
        private int stepFreq = 0;
        private int steps = 0;
        private bool stop = false;

        private SerialPort port = new SerialPort();

        public mainForm()
        {
            InitializeComponent();
            this.Text = title;
            scanPorts();
            loadSettings();
            prepareWork();
        }

        private void loadSettings()
        {
            startFreqTextBox.Text = Properties.Settings.Default["startFreq"].ToString();
            endFreqTextBox.Text = Properties.Settings.Default["endFreq"].ToString();
            stepFreqTextBox.Text = Properties.Settings.Default["stepFreq"].ToString();
            try
            {
                portComboBox.SelectedIndex = (int)Properties.Settings.Default["port"];
            }
            catch
            {
                portComboBox.SelectedIndex = 0;
            }
            if ((int)Properties.Settings.Default["dbv"] == 0) radioButtonV.Checked = true;
            if ((int)Properties.Settings.Default["dbv"] == 1) radioButtonDBV.Checked = true;
        }

        private void saveSettings()
        {
            Properties.Settings.Default["startFreq"] = startFreqTextBox.Text;
            Properties.Settings.Default["endFreq"] = endFreqTextBox.Text;
            Properties.Settings.Default["stepFreq"] = stepFreqTextBox.Text;
            Properties.Settings.Default["port"] = portComboBox.SelectedIndex;
            if (radioButtonV.Checked) Properties.Settings.Default["dbv"] = 0;
            if (radioButtonDBV.Checked) Properties.Settings.Default["dbv"] = 1;
            Properties.Settings.Default.Save();
        }

        private void prepareWork()
        {
            stop = false;
            //парсим данные из текстбоксов в int
            startFreq = Int32.Parse(startFreqTextBox.Text);
            endFreq = Int32.Parse(endFreqTextBox.Text);
            stepFreq = Int32.Parse(stepFreqTextBox.Text);
            steps = (endFreq - startFreq) / stepFreq;
        }

        private void scanPorts()
        {
            portComboBox.Items.Clear();
            foreach (string lport in SerialPort.GetPortNames())
                portComboBox.Items.Add(lport);
        }

        private void calibButton_Click(object sender, EventArgs e) //калибровка
        {
            prepareWork();
            stopButton.Visible = true;
            chart1.Series[0].Points.Clear();
            for (int freq = startFreq; freq <= endFreq; freq += stepFreq)
            {
                if (stop) return;
                if (freq > endFreq) freq = endFreq;

                double val = getData(freq);

                if (radioButtonDBV.Checked)  //dbV
                {
                    if (val > 0)
                        val = 20 * Math.Log10(val);
                    else
                        val = -120;
                }

                DataPoint dp = new DataPoint(freq, val);
                chart1.Series[0].Points.Add(dp);
            }
            stopButton.Visible = false;
        }

        private void startButton_Click(object sender, EventArgs e) //измерение
        {
            prepareWork();
            stopButton.Visible = true;
            chart1.Series[1].Points.Clear();

            double calibrateMaximum = 0;
            if (chart1.Series[0].Points.Count > 0)
                calibrateMaximum = chart1.Series[0].Points.Max(point => point.YValues[0]); //берём максимальный уровень из калибровочного прохода

            for (int freq = startFreq; freq <= endFreq; freq += stepFreq)
            {
                if (stop) return;
                if (freq > endFreq) freq = endFreq;
                double val = getData(freq);

                if (radioButtonDBV.Checked) //dbV
                {
                    if (val > 0)
                        val = 20 * Math.Log10(val);
                    else
                        val = -120;
                }

                double calibPoint = 0;
                if (chart1.Series[0].Points.Count > 0 && chart1.Series[0].Points.Where(point => point.XValue == freq).Count() > 0)
                    calibPoint = chart1.Series[0].Points.Where(point => point.XValue == freq).First().YValues[0]; //выбираем соответствующее значение из калибровки
                double calibrateOffset = calibrateMaximum - calibPoint; //получаем насколько ниже значение калибровки от максимума уровню (из-за нелинейности диода и генератора)
                val = val + calibrateOffset; //корректировка испытуемых значений

                DataPoint dp = new DataPoint(freq, val);
                chart1.Series[1].Points.Add(dp);
            }
            stopButton.Visible = false;
        }

        private double getData(int freq)
        {
            double res = 0;
            try
            {
                if (!port.IsOpen) port.Open();
                port.Write("GET " + freq + '\n');
                res = double.Parse(port.ReadLine());
            }
            catch
            {
                MessageBox.Show("Устройство не отвечает");
                stop = true;
                return 0;
            }
            Application.DoEvents();
            System.Threading.Thread.Sleep(10);
            currentFreqToolStripStatusLabel.Text = freq.ToString();
            return res;
        }

        private void portComboBox_DropDown(object sender, EventArgs e)
        {
            scanPorts();
        }

        private void portComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (portComboBox.SelectedItem.ToString() != "")
            {
                port = new SerialPort(portComboBox.SelectedItem.ToString(), 115200);
                port.ReadTimeout = 5000;
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stop = true;
            stopButton.Visible = false;
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            HitTestResult result = chart1.HitTest(e.X, e.Y);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                if (chart1.Series[0].Points.Count >= result.PointIndex)
                    nowFreqtoolStripStatusLabel.Text = chart1.Series[0].Points[result.PointIndex].XValue.ToString();
                else
                    nowFreqtoolStripStatusLabel.Text = "-";
                if (chart1.Series[0].Points.Count >= result.PointIndex)
                    calibToolStripStatusLabel.Text = chart1.Series[0].Points[result.PointIndex].YValues[0].ToString();
                else
                    calibToolStripStatusLabel.Text = "-";
                if (chart1.Series[1].Points.Count >= result.PointIndex)
                    resultToolStripStatusLabel.Text = chart1.Series[1].Points[result.PointIndex].YValues[0].ToString();
                else
                    resultToolStripStatusLabel.Text = "-";
            }
        }
    }
}
