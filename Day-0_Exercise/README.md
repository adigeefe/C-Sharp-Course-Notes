# 1.Gün Ödevi

## Soru
Kodlama.io sistemimizde detaylı bir gezinti yapınız.

Sistemde şart blokları, döngüler ve fonksiyon(metot) olarak kullanıldığını düşündüğünüz kısımlar için aynen eğitimde yaptığımız gibi kodlar yazınız.

Örneğin : Kurslar List formatındadır. Bunun simulasyonunu yapınız.

## Cevap

Öncelikle kod tamamen kirlidir, yaklaşık 10 dakika gibi bir sürede yazıldı. Böyle bir kod kabul edilemez :smile:

Bizden Kodlama.io da bir gezinti yapıp şart blokları, döngüler ve fonksiyonları kullanarak birkaç kod yazmamız isteniyor. Login paneli yapalım.

```python
#Kodu bekletmek için kütüphane
import time
#Hash kullanmak için kütüphane
import hashlib

#Giris Bilgileri
#engindemirog:12345
#

# Kullanıcıların tanımlandığı fonksiyon. Normalde db'den gelir fakat şuan için öyle bir imkanımız yok.
def credentials():
  #fonksiyon dışında bu listeleri kullanmak için global yapmamız gerek.
  global kullaniciadlari
  global kullanicipasswd
  #Liste tanımlama Hashleri yine aynı şekilde hashlib kullanarak oluşturdum.
  kullaniciadlari=["9659b5983d14acc61f86ccd93dcb5ff0","2c61ebff5a7f675451467527df66788d"]
  kullanicipasswd=["827ccb0eea8a706c4c34a16891f84e7b","e56f489f44381f5898952a8f84d395e3"]


#Ekranı Temizle
print("\n"*60)

#Şifremizi girip decode eden bir fonksiyon
def sifregir():
	global a
	str2hash = input("Sifre:")
	password = hashlib.md5(str2hash.encode())
	a=(password.hexdigest()) 
    
#Kullanıcı adımızı girip decode eden bir fonksiyon
def adgir():
	global b
    #Input alalım.
	username = input("Kullanici adi giriniz :")
    #hashlib kütüphanesinden md5'i çekip aldığımız kullanıcı adını şifreliyelim
	kadi = hashlib.md5(username.encode())
	b=(kadi.hexdigest()) 

#Login paneli için fonksiyon.
def loginpanel():

  # Ters bir durumda sürekli tekrar etmesi için while döngüsü
  while 1:
    #Kullanıcı adımızı girmek için fonksiyona gidiyoruz.
    adgir()
    #b kullanıcı adlari listesinin 0. indexine eşitse
    if b == kullaniciadlari[0]:
      while 1:
          #sifre gir fonksiyonuna gidelim.
          sifregir()
          #a şifreler listesinin 0. indexine eşit değilse.
          if a != kullanicipasswd[0]:
            #Ekranı temizle
            print("\n"*60)
            #Şifrenin yanlış olduğunu belirt.
            print("Hatali Sifre!")
          else:
          # girdiğimiz şifre eşleşiyorsa döngülerden çık.
            break
      break
      #kopyala yapıştır.
    elif b == kullaniciadlari[1]:
      while 1:
          sifregir()
          if a != kullanicipasswd[1]:
            print("\n"*60)
            print("Hatali Sifre!")
          else:
            break
      break				
    else:
      print("\n"*60)
      print("Hatali Kullanici Adi")
  #Whiledan çıktık.
  print("\n"*60)
  print("\nYupiiii Sisteme Hosgeldin!!\n"*10)
  #Database'e erişebiliriz.
  database()

def database():
  print("Sisteme Yönlendiriliyorsun .")
  time.sleep(0.6)
  print("Sisteme Yönlendiriliyorsun ..")
  time.sleep(0.6)
  print("Sisteme Yönlendiriliyorsun ...")
  time.sleep(0.6)
  print("Sisteme Yönlendiriliyorsun ....")
  time.sleep(0.6)
  print("\n"*70)
  print("Burası verilerin depolandigi güvenli bir sistemdir.")

credentials()
loginpanel()
```
## Test

Öncelikle programızı çalıştırınca bize Kullanıcı adını soruyor.

![](https://i.imgur.com/kKI4kmt.png)


Kullanıcı adını yanlış girersek.

![](https://i.imgur.com/0L1IL9H.png)

Tekrar yanlış girersek :smile: 

![](https://i.imgur.com/0L1IL9H.png)

Doğru girelim

![](https://i.imgur.com/45WLGB1.png)


Şifre istiyor tabiki, bu sefer ilk doğru deniyelim.

![](https://i.imgur.com/LQAU3Co.png)

import ettiğimiz time kütüphanesi ile . .. ... şeklinde basit bir görüntüden sonra



![](https://i.imgur.com/rspOiPH.png)

Giriş yaptığımızı görüyoruz

Yanlış şifre denersek de

![](https://i.imgur.com/U21ChTG.png)

Tekrar tekrar sorucaktır.
