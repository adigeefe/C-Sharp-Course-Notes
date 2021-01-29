# Classlar giriş


Gerçek hayatta veriler sadece 1 tane bilgiden oluşmaz. Gerçek hayatta veriler genellikle birkaç veriden oluşur.

Bir excel sayfasında müşteri bilgileri tuttuğumuzu düşünelim. Bu bilgilerin içinde müşteriye ait tek bir bilgi yok, müşteriye ait bilgiler; Müşteri Adı, TCNo, Doğum yeri vs.

![](https://i.imgur.com/ErsdmKA.png)

Bir e-ticaret sistemini düşünelim orada bir ürün bilgisi olucak ürün adı, ürün imajı, indirim oranı, eski fiyatı, yeni fiyatı vs. 

Buna benzer örnekleri ele aldığımızda bu verileri biryerde tutmamız gerekiyor.
Biz stringde veri tuttuğumuzda sadece bir veri tutabiliyoruz.
```c#
string kurs1 = "C# Kursu"
```
Fakat bizim ihtiyacımız olan aynı excel tablosundaki gibi bir kullanıcıya ait birden fazla veri ve bu verileride kolay bir şekilde tanımlayıp kolay bir şekilde ulaşmak.

İşte bu yüzden biz classları kullanıyoruz.

Hemen solution üzerinden yeni bir proje ekleyip girişimizi yapalım.

## Classlar

Öncelikle bu bilgileri normalde nasıl tanımlarız

```c#
static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = "36";
        }
```
Classlarda ise

```c#
Kurs kurs1;
```
Şeklinde bir değişken tanımlıyoruz (Benimde hiçbir fikrim yok ileride görücez) bunun için Kurs adında bir class olması gerekiyor hemen oluşturalım.

class yazıp bıraktığımızda yine intelesense'in açıldığını görüyoruz

![](https://i.imgur.com/QjbJp44.png)

TAB+TAB yapıp template'i bir görelim

![](https://i.imgur.com/BGtoUqo.png)

Beklediğimden çok daha basit bir template geldi :smile: 
Class ismini kurs yapalım ve class içine girip prop yazalım

![](https://i.imgur.com/5v1L7Zn.png)

Intelesense'imiz geldi yine aynı şekilde TAB+TAB

![](https://i.imgur.com/u0Eiysw.png)

Templatemiz geldi, int olarak geldi onu string yapıp, ismide Kursadi yapalım. get; set; kısımlarına şuan için dikkat etmiyelim.
(Çıkan referanslar'a dikkat etmeyin onları önceden yazdığım için gösteriyor kafanızı karıştırmasın. Şimdilik sizde 0 olucak hepsi.)
![](https://i.imgur.com/MOzZlKP.png)

Birkaç tane daha bilgi ekliyelim ve bir kurs objesi oluşturalım, toplamda 3 property (özellik) olsun 

```c#
 class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
```
Ana programda bu classı tanımlamamız gerekiyor ve bu şekilde tanımlıyoruz.
Classları kullanmak için bunu yapmak zorundayız.
```c#
Kurs kurs1 = new Kurs();
```
ve ardından

```c#
Kurs kurs1 = new Kurs();

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Engin Demirog";
kurs1.IzlenmeOrani = 68;

```
Bir kaç kurs daha eklemek istiyorum. Kopyala yapıştır yapıp kurs1 alanlarını kurs2, kurs3 olarak ve atadığım değerleri değiştiriyorum.
```c#
Kurs kurs1 = new Kurs();

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Engin Demirog";
kurs1.IzlenmeOrani = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Piton";
kurs2.Egitmen = "Guido van Rossum";
kurs2.IzlenmeOrani = 110;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Privacy";
kurs3.Egitmen = "Anonymous";
kurs3.IzlenmeOrani = 80;
```

Tanımlamalarımızı yaptık eğer bunları tek tek değişken olarak tanımlasaydık hepsini tek tek yazdırmamız gerekirdi. Classda ise

```c#
//                              .--String Eklemek için bu artıları koymak zorundayız     
//                              |                  Bu bize iki değişkeni ":" stringi ile ayırmamızı sağlıyor
//                              ↓
Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
```

Aga iyi güzelde hani kodlama.io'daki gibi yapıcaktık ?
Hemen oraya dönelim, 

> Şimdi 3 kursumuz var ve hepsini tek seferde yapmamız gerekiyor bunu nasıl yaparız?

<details>
  <summary>Cevap</summary>

[foreach döngüsü](https://github.com/hd0sec/Adigeefe/tree/main/Kodlama.io/C%23%20Egitimleri/Day-1/Donguler#user-content-for:~:text=Foreach,-For'da)

</details>

</br></br></br></br></br></br></br></br></br></br></br></br></br>


Spoiler Bypass :sweat_smile: 

</br></br></br></br></br></br></br></br></br></br></br></br></br>

Şimdi döngüde yazdırmamız için liste oluşturmamız gerektiğini biliyoruz. String olsa nasıl tanımlarız?
```c#
string[] kurslar = new string[] 
{

};
```
Bu şekilde sadece **string** tutabiliyoruz. 
Fakat bu şekilde tanımlarsak;
```c#
Kurs[] kurslar = new Kurs[] 
{

};
```
Dizinin içinde **Kurs** tutabiliriz.

```c#
Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};
```
önceden string tutuyorduk şuan kurs objesi tutuyoruz. 
Kısacası normal bir dizide string tutarken string diyip bir string yazıyoruz (örnek:"C# Kursu"). Burda da kurs arrayi tutuyoruz ve içinde kurs tipinde veriler olması gerekiyor.

for döngümüzü oluşturalım

```c#
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            //            .-- Takma isim
            //            |        .-- Kaç kere dönüceğiz (detay önceki notda)
            //            ↓        ↓
            foreach (var kurs in kurslar)
            {
                Console.Write(kurs.KursAdi);
            }
```
Dediğimizde tüm kurs isimlerini bize yazdırıcaktır, biraz daha düzenleyecek olursak.

```c#
Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {    
                //                             .- Yeni satır ekler bununla uğraşmamak için Consol.WriteLine yazabiliriz. Otomatik olarak aşağı iner.
                //                            ↓
                Console.Write(kurs.KursAdi +"\n"+ kurs.Egitmen +"\n"+ kurs.IzlenmeOrani + "\n \n");
            }
```

Tüm kodumuzu inceliyelim

```c#
using System;

namespace ClassIntro
{

    class Program
    {
        static void Main(string[] args)
        {    
//    .----←Öncelikle Kurs classını kullanacağımız için classı oluşturalım.
//    |     
//    ↓     //Classı kullanmak için tanımlamamızı yaptık.
            Kurs kurs1 = new Kurs();
//    |      
//    ↓     //Verilerimizi Ekledik
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;
//     |       
//     ↓    //Classı kullanmak için tanımlamamızı yaptık.
            Kurs kurs2 = new Kurs();
//     |       
//     ↓    //Verilerimizi Ekledik
            kurs2.KursAdi = "Piton";
            kurs2.Egitmen = "Guido van Rossum";
            kurs2.IzlenmeOrani = 110;           
//     |       
//     ↓    //Classı kullanmak için tanımlamamızı yaptık.
            Kurs kurs3 = new Kurs();
//     |       
//     ↓    //Verilerimizi Ekledik            
            kurs3.KursAdi = "Privacy";
            kurs3.Egitmen = "Anonymous";
            kurs3.IzlenmeOrani = 80;
//     |       
//     ↓    //Tüm bu kursları yazdırmak için dizi tanımımızı yaptık.
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
//     |       
//     ↓    //döngü ile yazdırdık.
            foreach (var kurs in kurslar)
            {
                Console.Write(kurs.KursAdi +"\n"+ kurs.Egitmen +"\n"+ kurs.IzlenmeOrani + "\n \n");
            }
//     |         
//     ↓        
        }
    }
//     ↓
//     "--→Classımızı oluşturalım ve başa dönelim.
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}   

```

Çıktımız nasıl olucak?

![](https://i.imgur.com/e9VF9wG.png)

Tam istediğimiz gibi! İstersek satır başlarına satırla ait bilgiler de verebiliriz
örnek;
```c#
Console.Write("Kurs:" + kurs.KursAdi +"\n Egitmen:"+ kurs.Egitmen +"\n Izlenme Orani"+ kurs.IzlenmeOrani + "\n \n");
```
Sonuç bu şekilde olucaktır.

![](https://i.imgur.com/oOsrn15.png)

Güzel bir gündü :+1: :100: 
