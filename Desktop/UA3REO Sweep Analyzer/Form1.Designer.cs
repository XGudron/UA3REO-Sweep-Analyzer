﻿namespace UA3REO_Sweep_Analyzer
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.presetsButton = new System.Windows.Forms.Button();
            this.presetsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.calibButton = new System.Windows.Forms.Button();
            this.stepFreqTextBox = new System.Windows.Forms.TextBox();
            this.endFreqTextBox = new System.Windows.Forms.TextBox();
            this.startFreqTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentFreqToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.nowFreqtoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.calibToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.resultToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.repeatCheckBox = new System.Windows.Forms.CheckBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.radioButtonDBV = new System.Windows.Forms.RadioButton();
            this.radioButtonV = new System.Windows.Forms.RadioButton();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.presetsContextMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.presetsButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.calibButton);
            this.panel1.Controls.Add(this.stepFreqTextBox);
            this.panel1.Controls.Add(this.endFreqTextBox);
            this.panel1.Controls.Add(this.startFreqTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 38);
            this.panel1.TabIndex = 0;
            // 
            // presetsButton
            // 
            this.presetsButton.ContextMenuStrip = this.presetsContextMenuStrip;
            this.presetsButton.Location = new System.Drawing.Point(11, 3);
            this.presetsButton.Name = "presetsButton";
            this.presetsButton.Size = new System.Drawing.Size(24, 23);
            this.presetsButton.TabIndex = 9;
            this.presetsButton.Text = ">";
            this.presetsButton.UseVisualStyleBackColor = true;
            this.presetsButton.Click += new System.EventHandler(this.presetsButton_Click);
            // 
            // presetsContextMenuStrip
            // 
            this.presetsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.mToolStripMenuItem,
            this.mToolStripMenuItem1,
            this.mToolStripMenuItem2,
            this.mToolStripMenuItem3,
            this.mToolStripMenuItem4,
            this.mToolStripMenuItem5,
            this.mToolStripMenuItem6,
            this.mToolStripMenuItem7,
            this.mToolStripMenuItem8});
            this.presetsContextMenuStrip.Name = "presetsContextMenuStrip";
            this.presetsContextMenuStrip.Size = new System.Drawing.Size(121, 246);
            this.presetsContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.presetsContextMenuStrip_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem1.Text = "0-55Mhz";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem2.Text = "0-30Mhz";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.mToolStripMenuItem.Text = "160M";
            this.mToolStripMenuItem.Click += new System.EventHandler(this.mToolStripMenuItem_Click);
            // 
            // mToolStripMenuItem1
            // 
            this.mToolStripMenuItem1.Name = "mToolStripMenuItem1";
            this.mToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.mToolStripMenuItem1.Text = "80M";
            this.mToolStripMenuItem1.Click += new System.EventHandler(this.mToolStripMenuItem1_Click);
            // 
            // mToolStripMenuItem2
            // 
            this.mToolStripMenuItem2.Name = "mToolStripMenuItem2";
            this.mToolStripMenuItem2.Size = new System.Drawing.Size(120, 22);
            this.mToolStripMenuItem2.Text = "40M";
            this.mToolStripMenuItem2.Click += new System.EventHandler(this.mToolStripMenuItem2_Click);
            // 
            // mToolStripMenuItem3
            // 
            this.mToolStripMenuItem3.Name = "mToolStripMenuItem3";
            this.mToolStripMenuItem3.Size = new System.Drawing.Size(120, 22);
            this.mToolStripMenuItem3.Text = "30M";
            this.mToolStripMenuItem3.Click += new System.EventHandler(this.mToolStripMenuItem3_Click);
            // 
            // mToolStripMenuItem4
            // 
            this.mToolStripMenuItem4.Name = "mToolStripMenuItem4";
            this.mToolStripMenuItem4.Size = new System.Drawing.Size(120, 22);
            this.mToolStripMenuItem4.Text = "20M";
            this.mToolStripMenuItem4.Click += new System.EventHandler(this.mToolStripMenuItem4_Click);
            // 
            // mToolStripMenuItem5
            // 
            this.mToolStripMenuItem5.Name = "mToolStripMenuItem5";
            this.mToolStripMenuItem5.Size = new System.Drawing.Size(120, 22);
            this.mToolStripMenuItem5.Text = "17M";
            this.mToolStripMenuItem5.Click += new System.EventHandler(this.mToolStripMenuItem5_Click);
            // 
            // mToolStripMenuItem6
            // 
            this.mToolStripMenuItem6.Name = "mToolStripMenuItem6";
            this.mToolStripMenuItem6.Size = new System.Drawing.Size(120, 22);
            this.mToolStripMenuItem6.Text = "15M";
            this.mToolStripMenuItem6.Click += new System.EventHandler(this.mToolStripMenuItem6_Click);
            // 
            // mToolStripMenuItem7
            // 
            this.mToolStripMenuItem7.Name = "mToolStripMenuItem7";
            this.mToolStripMenuItem7.Size = new System.Drawing.Size(120, 22);
            this.mToolStripMenuItem7.Text = "12M";
            this.mToolStripMenuItem7.Click += new System.EventHandler(this.mToolStripMenuItem7_Click);
            // 
            // mToolStripMenuItem8
            // 
            this.mToolStripMenuItem8.Name = "mToolStripMenuItem8";
            this.mToolStripMenuItem8.Size = new System.Drawing.Size(120, 22);
            this.mToolStripMenuItem8.Text = "10M";
            this.mToolStripMenuItem8.Click += new System.EventHandler(this.mToolStripMenuItem8_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(813, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(84, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(723, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(84, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // calibButton
            // 
            this.calibButton.Location = new System.Drawing.Point(633, 5);
            this.calibButton.Name = "calibButton";
            this.calibButton.Size = new System.Drawing.Size(84, 23);
            this.calibButton.TabIndex = 6;
            this.calibButton.Text = "Калибровать";
            this.calibButton.UseVisualStyleBackColor = true;
            this.calibButton.Click += new System.EventHandler(this.calibButton_Click);
            // 
            // stepFreqTextBox
            // 
            this.stepFreqTextBox.Location = new System.Drawing.Point(527, 5);
            this.stepFreqTextBox.Name = "stepFreqTextBox";
            this.stepFreqTextBox.Size = new System.Drawing.Size(100, 20);
            this.stepFreqTextBox.TabIndex = 5;
            this.stepFreqTextBox.Text = "500000";
            // 
            // endFreqTextBox
            // 
            this.endFreqTextBox.Location = new System.Drawing.Point(364, 5);
            this.endFreqTextBox.Name = "endFreqTextBox";
            this.endFreqTextBox.Size = new System.Drawing.Size(100, 20);
            this.endFreqTextBox.TabIndex = 4;
            this.endFreqTextBox.Text = "55000000";
            // 
            // startFreqTextBox
            // 
            this.startFreqTextBox.Location = new System.Drawing.Point(151, 5);
            this.startFreqTextBox.Name = "startFreqTextBox";
            this.startFreqTextBox.Size = new System.Drawing.Size(100, 20);
            this.startFreqTextBox.TabIndex = 3;
            this.startFreqTextBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Step, Hz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Frequency, Hz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Frequency, Hz:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.currentFreqToolStripStatusLabel,
            this.toolStripStatusLabel2,
            this.nowFreqtoolStripStatusLabel,
            this.toolStripStatusLabel3,
            this.calibToolStripStatusLabel,
            this.toolStripStatusLabel4,
            this.resultToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1018, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(168, 17);
            this.toolStripStatusLabel1.Text = "Текущая частота генератора:";
            // 
            // currentFreqToolStripStatusLabel
            // 
            this.currentFreqToolStripStatusLabel.Name = "currentFreqToolStripStatusLabel";
            this.currentFreqToolStripStatusLabel.Size = new System.Drawing.Size(12, 17);
            this.currentFreqToolStripStatusLabel.Text = "-";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(117, 17);
            this.toolStripStatusLabel2.Text = "Выбранная частота:";
            // 
            // nowFreqtoolStripStatusLabel
            // 
            this.nowFreqtoolStripStatusLabel.Name = "nowFreqtoolStripStatusLabel";
            this.nowFreqtoolStripStatusLabel.Size = new System.Drawing.Size(12, 17);
            this.nowFreqtoolStripStatusLabel.Text = "-";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(132, 17);
            this.toolStripStatusLabel3.Text = "Значение калибровки:";
            // 
            // calibToolStripStatusLabel
            // 
            this.calibToolStripStatusLabel.Name = "calibToolStripStatusLabel";
            this.calibToolStripStatusLabel.Size = new System.Drawing.Size(12, 17);
            this.calibToolStripStatusLabel.Text = "-";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(126, 17);
            this.toolStripStatusLabel4.Text = "Значение измерения:";
            // 
            // resultToolStripStatusLabel
            // 
            this.resultToolStripStatusLabel.Name = "resultToolStripStatusLabel";
            this.resultToolStripStatusLabel.Size = new System.Drawing.Size(12, 17);
            this.resultToolStripStatusLabel.Text = "-";
            this.resultToolStripStatusLabel.Click += new System.EventHandler(this.resultToolStripStatusLabel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 390);
            this.panel2.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX2.IsStartedFromZero = false;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.MaximumAutoSize = 100F;
            chartArea1.AxisY2.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Калибровка";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Измерение";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(873, 390);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "mainChart";
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.repeatCheckBox);
            this.panel3.Controls.Add(this.stopButton);
            this.panel3.Controls.Add(this.radioButtonDBV);
            this.panel3.Controls.Add(this.radioButtonV);
            this.panel3.Controls.Add(this.portComboBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(873, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 390);
            this.panel3.TabIndex = 1;
            // 
            // repeatCheckBox
            // 
            this.repeatCheckBox.AutoSize = true;
            this.repeatCheckBox.Location = new System.Drawing.Point(6, 92);
            this.repeatCheckBox.Name = "repeatCheckBox";
            this.repeatCheckBox.Size = new System.Drawing.Size(115, 17);
            this.repeatCheckBox.TabIndex = 5;
            this.repeatCheckBox.Text = "Работать в цикле";
            this.repeatCheckBox.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(6, 115);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(127, 23);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Остановить работу";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // radioButtonDBV
            // 
            this.radioButtonDBV.AutoSize = true;
            this.radioButtonDBV.Location = new System.Drawing.Point(6, 69);
            this.radioButtonDBV.Name = "radioButtonDBV";
            this.radioButtonDBV.Size = new System.Drawing.Size(44, 17);
            this.radioButtonDBV.TabIndex = 3;
            this.radioButtonDBV.Text = "dbV";
            this.radioButtonDBV.UseVisualStyleBackColor = true;
            // 
            // radioButtonV
            // 
            this.radioButtonV.AutoSize = true;
            this.radioButtonV.Checked = true;
            this.radioButtonV.Location = new System.Drawing.Point(6, 46);
            this.radioButtonV.Name = "radioButtonV";
            this.radioButtonV.Size = new System.Drawing.Size(32, 17);
            this.radioButtonV.TabIndex = 2;
            this.radioButtonV.TabStop = true;
            this.radioButtonV.Text = "V";
            this.radioButtonV.UseVisualStyleBackColor = true;
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(6, 19);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(127, 21);
            this.portComboBox.TabIndex = 1;
            this.portComboBox.DropDown += new System.EventHandler(this.portComboBox_DropDown);
            this.portComboBox.SelectedIndexChanged += new System.EventHandler(this.portComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Порт:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "mainForm";
            this.Text = "UA3REO Frequency Analizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.presetsContextMenuStrip.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button calibButton;
        private System.Windows.Forms.TextBox stepFreqTextBox;
        private System.Windows.Forms.TextBox endFreqTextBox;
        private System.Windows.Forms.TextBox startFreqTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel currentFreqToolStripStatusLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonDBV;
        private System.Windows.Forms.RadioButton radioButtonV;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel nowFreqtoolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel calibToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel resultToolStripStatusLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox repeatCheckBox;
        private System.Windows.Forms.Button presetsButton;
        private System.Windows.Forms.ContextMenuStrip presetsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem8;
    }
}

