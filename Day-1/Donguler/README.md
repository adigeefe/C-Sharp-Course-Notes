# Eklemeler

> Dizileri pythondan aşinalığım olduğu için liste şeklinde açıklamışım. C#'da dizi olarak geçtiğini öğrendim. Yani Liste değil dizi, zaten mantığıda aynı.

# Döngüler

Öncelikle, Solution Explorer nedir?
Solution Explorer içinde birbiriyle ilişkili projeler barındırılır.
Örneğin bir şube düşünürsek bu şubede masaüstü yazılımı, şubenin internet bankacılığı vs. projeleri olucaktır. Bu projeler Solution Explorer içerisinde toplanır.


![](https://i.imgur.com/eJQmCtv.png)

Solution Explorer üzerinde sağ tıklayıp açılan pencerede Add > New Project ile yeni bir proje oluşturalım.

![](https://i.imgur.com/xvzL28t.png)

Projemiz Console App (.NET Core) olsun.



## Giriş

Öncelikle döngüleri nerelerde kullanırız sorusuna çok basit bir cevap verelim.
Kodlama.io websitesinin tasarımına basitçe bakarsak 2 adet kurs 2 adet filtereleme seçeneği 4 tane de buton olduğunu görebiliyoruz.
Kursları ele alalım. Buradaki 2 kursu döngüler sayesinde gösterebiliriz (Örnek olarak gösteriyoruz web tasarımda bayağı farklı)

![](https://i.imgur.com/nGTqsEM.png)


Bunları yapabilmek için öncelikle listelere değinmemiz gerektiğini düşünüyorum.

## Liste Nedir?

Şuanda bizim bildiğimiz tek şey var o da değişkenler. Öncelikle neden listeye ihtiyacımız var ona bir göz atalım.

Normal olarak bu kursları, kursların kutularını bir string gibi düşünelim yani bir obje gibi düşünelim. Eğer bunları şuan bildiklerimizle yapmak istersek aşağıdaki örnekde ki gibi string tanımlayıp hepsini tek tek yazdırmamız gerekiyor.
```c#
using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kursu"
            string kurs2 = "Programlamaya giriş"
            string kurs3 = "Basit C++ Kursu"
            // vs.
            
            Console.WriteLine(kurs1)
            Console.WriteLine(kurs2)
            Console.WriteLine(kurs3)
        }
    }
}
```
Bu şekilde gayet güzel bir şekilde kursların sırayla yazdırıldığını görebiliriz. Herşey güzel herşey yolunda. Fakat...(ah şu fakatlar olmasa :) ) 
Fakat bir e ticaret sitesini düşündüğümüzde karşımıza tek bir sayfa da bir çok ürün çıkabilir, e peki bunları biz tek tek tanımlayıp tek tek yazdırıcakmıyız? Tabiki hayır.

İşte burda olaya Döngüler ve listeler geliyor. Öncelikle tanımlamayı yani listeleri sonrasında yazdırmayı yani döngülere bakalım. 

Yukarıda string olarak kurs1, kurs2, kurs3 tanımlamaları yaptık. Bunları bir döngüde (benim dediğime göre "kolay bir şekilde") yazdırmamız için listelere ihtiyacımız var.
Ben mutfak için alınıcaklar listesi yapıyorum diyelim; elma, armut, karpuz vs. gibi tek bir kağıtta tek bir liste tutarım. Burada da kurslar için kurs1, kurs2, kurs3 olarak dizi/liste/array yazmamız gerekiyor.

Diziler nasıl tanımlanır?

```c#
using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
//Tanımlama olarak da böyle, 
//           .--stringden oluşan
//           |       .--alinicaklar adında ki dizimize 
//           |       |                     .-- Birkaç adet eleman tanımladık.
//           |       |                     |
//           ↓       ↓                     ↓
         string[] alinicaklar = new string[] {"elma", "armut", "karpuz"};

        //Gerçek hayatta veriler bir kaynak geldiği için tanımlaması biraz farklı.
        //Gerçek hayatta bu şekilde örnek bir tanımlaması var.
        //Burada alinacaklar listesini bir veri kaynagından örneğin listeyi zaten bilen birisinden tanımlanıyor. 
         string[] alinicaklar =  alinicaklariOgren();
         
         //Gerçek hayat örneğini alıncaklardan yapmak biraz kafa karıştırıcı.
         //Kurslar üzerinden gidelim
         //kurslar dizisini/listesini veri kaynagindan gelen bir veriyle tanimliyoruz. 
         //Eğitim kısmında olduğumuz için ve daha da kafa karıştırmayı ilerliyoruz.
         string[] kurslar =  kurslariGetir();
        
        //Dizileri tanımlamayı öğrendiğimize göre işimize dönelim
        string[] kurslar = new string[] {"Yazılım Geliştirici Kursu", "Programlamaya giriş", "Basit C++ Kursu"};
        }
    }
}
```

Normal şartlarda bu kursları ekrana yazdırmak isteseydim tek tek yazdırmamız gerektiğini zaten konuştuk. Şimdi array ile daha kolay nasıl yazdırabileceğimize bakalım.

## Döngüler
### For

Öncelikle Visual Studio'da for (for bir döngü) yazıp bıraktığımızda karşımıza böyle bir görüntü çıkıyor.

![](https://i.imgur.com/T4kAiYa.png)

Bu açılan kutunun adı intellisense'dir. Bu açılan kutuda for'un başında resimdeki gibi alt tarafı noktalardan oluşan bir kutu varsa anlayabiliriz ki burada snippet var, o ne demek? snippet kullanarak TAB tuşuna 2 kez ardı ardına bastığımızda for döngüsünün taslağını hızlıca oluşturabiliriz. Deneyelim.

2 kez TAB tuşuna bastığımız zaman for döngüsünün taslağını bize verdi.

![](https://i.imgur.com/K5IGjQG.png)


Burada for diyip parentez açıp içine bazı şeyleri otomatik olarak yazdı. Ne bu "şeyler"?

- int i = 0;
    * Burada değeri 0 olan bir i tamsayısı tanımlıyor.
- i < length;
    * i tam sayısı "length" (uzunluk)'dan küçüktür. length yerine şimdilik 10 yazalım. 
    * i < 10;
- i++
    * i tam sayısını 1 kez arttır. ++ bize bir tam sayıyı 1 kez arttırmamızı sağlıyor.

Bunlar ne demek? 
Bu şu bir i tam sayısı verdik, bir şart koştuk, ve i'yi 1 kez arttırdık i'yi arttırmamızın sebebi burada sayaç gibi bir işlev gördürmesini sağlamak.
Hiç birşey anlamadım...
Şöyle açıklama yapalım 
(i'den başla, yani 0'dan başla) EĞER (i 10'dan küçük) İSE (i'yi bir arttır)
Bu bize ne sağlıyo? Eğer ben for döngüsünü bu şekilde oluşturup içine i'yi yazdırdığım bir komut yazarsam (Console.WriteLine(i)) i'yi 10 kez bastırmamızı sağlıyor.
Deneyelim...


Kendimi bilgisayar yerine koyuyorum. Bana bir tam sayı (i) verildi ve bu 0.
Eğer tam sayı 10'dan küçükse, ki 0<10'dur. i tam sayısını yazdır. ve döngü bitiminde i tam sayısını 1 arttır.

Hemen yapıyorum.

```

i 0 dı. 0'ı yazdım
0
i'yi 1 arttırdım.
tekrar başa döndüm 
i tam sayısı 1, 1'i yazdım
1
i'yi 1 arttırdım.
i tam sayısı 2 oldu, 2'yi yazdım
2
i'yi 1 arttırdım.
tekrar başa döndüm
.
.
.
```
Bana birisi bunu dediğinde ben bu şekilde yaparım. Birde bilgisayar nasıl yapıyor onu görelim.

![](https://i.imgur.com/I8Bzreg.png)

Bizim yaptığımızın aynısını bilgisayarda yaptı.
10'u yazmamasının sebebi ise şartımızın o şekilde olduğu. eğer i <= 10 (i küçük eşittir 10) yaparsak bize 10'u da yazdırır.
Burda ki şartları istediğimiz gibi yönlendirebiliriz. Mesela 1, 1 arttırmak yerine 2, 2 arttırmak istersek (i=i+2) veya (i+=2) yazabiliriz.

- Yahu tamamda ne 0'ı ne 1'i napıyoz biz hani kursları yazdırıcaktık?
- Çalışma mantığını ve taslağını gördük şimdi kursları yazdıralım :smiley: 

```c#
using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zaten dizimizi önceden tanımlamıştık.
            string[] kurslar = new string[] {"Yazılım gelistirme", "programlamaya başlangıç",
                "Java"};
            
            // Bu kodu programa geçirip çalıştırdığımızda tüm kursların bize getirlidğini gördük.
            //Nasıl çalıştı şimdi bu?
             
            //                    .--10 yerine kurslar.Length yazmışız.
            //                   |        kurslar    nokta   Length
            //                   |     Bu kurslar(dizisinin)Uzunluğu anlamına geliyor
            //                   |    Yani kurslar dizisinde 5 elemanımız varsa i<5.
            //                   ↓
            for (int i = 0; i<kurslar.Length; i++)
            {
            //                    Bu ise kurslat dizisinin i. elemanını getir.
                Console.WriteLine(kurslar[i]);
            }

        }
    }
}
```
Toplayacak olursak yukarıda ki kodun Türkçesi, bizim listemizde 3 adet eleman var 3 i den büyük olduğu sürece, kursların i'ninci elemanını yazdır. Yukarıda 0,1,2,3 diye yazdırmıştı bu sefer 0 yerine kurslar listesinin 0'elemanı yani "Yazılım gelistirme"'yi ardından 1. elemanı yazdırarak gidicektir.

Çalıştıralım :computer: 

![](https://i.imgur.com/gAHQ5pW.png)

:+1: 

### Foreach

For'da olduğu gibi bir de bizim foreach'imiz var. Yine aynı şekilde snippet kullanarak getirdiğimiz taslağa bir göz atalım.

![](https://i.imgur.com/9V1BiEC.png)

Burada for'da olduğu gibi i değişkenimiz yok ki zaten foreach'in özelliği bu.
Foreach dizi temelli yapıları tek tek dönmeye yarıyor.

```c#
//                 .--Alias/ kurslar dizisini tek tek dolaşırken yani dizinin her bir elemanı için tek tek dönerken her elemanı bir değişkene atamaya ihtiyacımız var o değikende bu oluyor yani burayı abc veya x de yapabiliriz.        
//                |        .--kurslar dizisini tek tek dolaş.
//                ↓        ↓
foreach (string kurs in kurslar)
    {
        Console.WriteLine(kurs)
    }
```
Kıyaslayacak olursak genellikle foreach kullanılır.
