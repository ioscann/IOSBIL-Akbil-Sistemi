#include <MFRC522.h>
#include <LiquidCrystal.h>
#include <virtuabotixRTC.h>

MFRC522 rfid(10,9); // SDA -> 10 RST -> 9
LiquidCrystal lcd(7,6,5,4,3,2); // RS -> 7 E -> 6 D4 -> 5 D5 -> 4 D6 -> 3 D7 -> 2
virtuabotixRTC myRTC(8,A0,A1); // CLK -> 8 DAT -> A0 RST -> A1

void setup() 
{
  Serial.begin(9600);
  SPI.begin();
  rfid.PCD_Init();
  lcd.begin(16,2);
  myRTC.setDS1302Time(0,0,16,5,15,7,2022); // saniye-dakika-saat-haftanın günü-ayın günü-ay-yıl şeklinde yazılır
  pinMode(A2,OUTPUT); //BUZZER
}

void getTime()
{
  myRTC.updateTime();
  lcd.clear();
  lcd.setCursor(0,0);

  lcd.print("Tarih: ");
  lcd.print(myRTC.dayofmonth);
  lcd.print("/");
  lcd.print(myRTC.month);
  lcd.print("/");
  lcd.print(myRTC.year);

  lcd.setCursor(0,1);

  lcd.print("Saat: ");
  lcd.print(myRTC.hours);
  lcd.print(":");
  lcd.print(myRTC.minutes);
  lcd.print(":");
  lcd.print(myRTC.seconds);

  delay(1000); 
}

void loop() 
{

  if (Serial.available())
  {
    char data = Serial.read();

    if (data == '0') {lcd.clear();}
    else if (data == '1') {lcd.clear(); lcd.print("Giris basarili");}
    else if (data == '2') {lcd.clear(); lcd.print("Giris basarisiz");}
    else if (data == 's') {digitalWrite(A2,1); delay(500); digitalWrite(A2,0);}
    else if (data == 't') {lcd.clear(); lcd.print("Test");}
    else if (data == 'c') {lcd.clear(); getTime();}
  }
  
  if (!rfid.PICC_IsNewCardPresent())
    return; // mevcut okutulan karttan başka bir kart gelmediğinde başa dön
  if (!rfid.PICC_ReadCardSerial())
    return; // herhangi bir kart okutulmadığında değerlerin ekrana gelmemesini sağlıyor

  for (int i=0;i<rfid.uid.size;i++) { Serial.print(rfid.uid.uidByte[i]);}
  digitalWrite(A2,1); delay(500); digitalWrite(A2,0);
  
  rfid.PICC_HaltA(); //yeni bir kart okutulana kadar çalışmayı durdurur
}
