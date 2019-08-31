#include <Adafruit_GFX.h>
#include <Adafruit_SPITFT.h>
#include <Adafruit_PCD8544.h>
#include "./AD9850/DDS.h"    //http://github.com/F4GOJ/AD9850
#include "./AD9850/DDS.cpp"

// pin 6 - Serial clock out (SCLK)
// pin 7 - Serial data out (DIN)
// pin 8 - Data/Command select (D/C)
// pin 9 - LCD chip select (CS)
// pin 10 - LCD reset (RST)
#define DISPLAY_BACKLIGHT_PIN 17 //NOKIA 5110 LCD
#define VIN1_ADC_PIN 14 //ARDUINO NANO
#define VIN2_ADC_PIN 15 //ARDUINO NANO
Adafruit_PCD8544 display = Adafruit_PCD8544(6, 7, 8, 9, 10);

const int W_CLK = 12; //DDS 9850
const int FQ_UD = 4; //DDS 9850
const int DATA = 11; //DDS 9850
const int RESET = 5; //DDS 9850
DDS dds(W_CLK, FQ_UD, DATA, RESET);
long freq = 35000000; //current freq
long calibrateFreq = 124999600; //вводим реальную частоту кварца для колибровки

#define ENC_CLK 2
#define ENC_DT A5
#define ENC_SW 3
int enc_FreqStep = 1; //шаг изменения частоты для энкодера
long enc_StepMultip = 1; //множитель шага энкодера (hz,khz,mhz)
int enc_ALast;
int enc_AVal;

int vin1 = 0; //Volts in ADC1
int vin2 = 0; //Volts in ADC2
float vin = 0; //Volts rounded
String freq_string_hz;
String freq_string_khz;
String freq_string_mhz;
long debouncing_time = 500; //Защита от дребезга в миллисекундах
volatile unsigned long last_micros;

String serial_readline;
const int bSize = 64; //serial buffer size from desktop
char Buffer[bSize]; //serial buffer from desktop

void setup() {
  Serial.begin(115200);
  Serial.setTimeout(100);

  analogReference(INTERNAL);

  pinMode (W_CLK, OUTPUT);
  pinMode (DATA, OUTPUT);
  pinMode (ENC_DT, INPUT);
  pinMode (ENC_CLK, INPUT);
  pinMode (ENC_SW, INPUT_PULLUP);

  enc_ALast = digitalRead(ENC_CLK);

  analogWrite(DISPLAY_BACKLIGHT_PIN, 150);
  display.begin();
  display.setContrast(60);
  display.clearDisplay();
  display.setTextSize(1);
  display.setTextColor(BLACK);
  display.setCursor(0, 0);

  dds.init();
  dds.trim(calibrateFreq); //вводим реальную частоту кварца
  dds.setFrequency(freq);

  attachInterrupt(0, checkEncoder, CHANGE);
  attachInterrupt(1, switchMultiplier, FALLING);

  //Serial.println("Setup complete");
}

void loop() {
  while (Serial.available() > 0)
  {
    memset(Buffer, 0, bSize);
    Serial.readBytesUntil('\n', Buffer, bSize);
    serial_readline = String(Buffer);
    if (serial_readline.startsWith("GET "))
    {
      freq = (long)serial_readline.substring(4).toFloat();
      dds.setFrequency(freq);
      Serial.println(readInVoltage(),6);
    }
    Serial.flush();
  }

  printInfo();

  if (freq < 0) freq = 0;
  if (freq > calibrateFreq) freq = calibrateFreq;
  //delay(300);
}

void switchMultiplier() { //смена разрадности переключения частоты валкодером
  if (digitalRead(ENC_SW) == HIGH) return;
  detachInterrupt(1);

  if ((long)(micros() - last_micros) >= debouncing_time * 1000) { //защита от дребезга контактов
    if (digitalRead(ENC_SW) == LOW)
    {
      if (enc_StepMultip == 1) enc_StepMultip = 1000;
      else if (enc_StepMultip == 1000) enc_StepMultip = 1000000;
      else enc_StepMultip = 1;
    }
    last_micros = micros();
  }
  attachInterrupt(1, switchMultiplier, FALLING);
}

void checkEncoder() {
  enc_AVal = digitalRead(ENC_CLK);
  if (enc_AVal != enc_ALast) { // проверка на изменение значения на выводе А по сравнению с предыдущим запомненным, что означает, что вал повернулся
    // а чтобы определить направление вращения, нам понадобится вывод В.
    if (digitalRead(ENC_DT) != enc_AVal) {  // Если вывод A изменился первым - вращение по часовой стрелке
      freq = freq + enc_FreqStep * enc_StepMultip;
      dds.setFrequency(freq);
    } else {// иначе B изменил свое состояние первым - вращение против часовой стрелки
      freq = freq - enc_FreqStep * enc_StepMultip;
      dds.setFrequency(freq);
    }
  }
  enc_ALast = enc_AVal;
}

void printInfo() { //вывод информации на экран
  display.clearDisplay();
  display.setCursor(0, 0);

  vin = readInVoltage();

  display.print("IN: ");
  display.print(vin, 6);
  display.println("V");

  //добавляем пробелов для вывода частоты
  freq_string_hz.reserve(3);
  freq_string_hz = String(freq % 1000);
  freq_string_khz = String((long)(freq / 1000) % 1000);
  freq_string_mhz = String((long)(freq / 1000000) % 1000000);

  if (enc_StepMultip == 1000000) display.setTextColor(WHITE, BLACK);
  display.print(freq_string_mhz);
  display.setTextColor(BLACK, WHITE);
  display.print(" ");

  if (enc_StepMultip == 1000) display.setTextColor(WHITE, BLACK);
  display.print(addNuls(freq_string_khz));
  display.setTextColor(BLACK, WHITE);
  display.print(" ");

  if (enc_StepMultip == 1) display.setTextColor(WHITE, BLACK);
  display.print(addNuls(freq_string_hz));
  display.setTextColor(BLACK, WHITE);
  display.println("Hz");

  display.display();
}

String addNuls(String str) //добавляем нули, чтобы получить по 3 в группе
{
  if (str.length() == 1) return "00" + str;
  if (str.length() == 2) return "0" + str;
  return str;
}

float readInVoltage() //читаем частоту с ADC
{
  vin = 0;
  for (int i = 0; i < 12; i++)
  {
    vin1 = analogRead(VIN1_ADC_PIN);
    vin2 = analogRead(VIN2_ADC_PIN);
    vin = vin + ((((float)vin1 + (float)vin2) / 2) / 1023 * 1.1);
  }
  vin = vin / 12;
  return vin;
}

