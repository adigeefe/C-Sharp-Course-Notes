## Bir değişkenin tanımlanması
```c#
using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do not repeat yourself--↓
            //Neden direkt print ile yazdırmıyoruz da string tanımlıyoruz?
            //Tüm sayfalarda tek tek değiştirmek yerine tanımlanan string değiştirilir.
            
            
            //    değer tutucu/alias
            string kategoriEtiketi = "Kategori";

            
            //1.sayfa
            Console.WriteLine(kategoriEtiketi);
            //2.sayfa
            Console.WriteLine(kategoriEtiketi);
            //3.sayfa
            Console.WriteLine(kategoriEtiketi);
        }
    }
}



```

## Bazı Değişkenler
```c#
using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {            
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            //C#'da C++'da olduğu gibi bazı değişkenlerin max değerleri vardır.
            //Bu değerler aşağıdaki tabloda gösterilicek.
 
            double faizOrani = 1.86421333;
            bool girisyapildimi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;    
        
        }
    }
}
```


## Değişkenlerin Kullanımları

```c#
using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            
            //Bir web sayfasında ki session'ı kontrol ettiğimizi düşünebiliriz.
            bool girisyapildimi = false;
            
            //Gerçek bir faiz hesaplama web sitesini sümile edelim.
            double faizOrani = 1.86421333;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            
            //EĞER dünkü dolar bugunkü dolardan büyükse
            if (dolarDun>dolarBugun)
            {
                //Dolar azalıyor. :')
                Console.WriteLine("Azalış ikonu");
            }
            
            //DEĞİLSE EĞER bugunkü dolar dünkü dolardan büyükse
            else if (dolarDun < dolarBugun)
            {
                //Dolar artıyor.
                Console.WriteLine("Artış ikonu");
            }
            
            //HİÇBİRİ DEĞİLSE
            else
            {
                //Bir değişiklik olmamışdır
                Console.WriteLine("Değişmedi ikonu");
            }
            
            
            //Kodlama.io'da ki giriş yap butonunun session'ı referans alarak gösterilmesi.
            if (girisyapildimi==true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
        }
    }
```



## Bazı Değerler
---

| int | uint | long | ulong |
| :-------: | :-------: | :-------: | :-------: |
| 32 bitlik işaretli tam sayıları tutar.     | 32 bitlik işaretsiz tam sayıları tutar. Uint, işaretsiz anlamına gelir.     | 64 bitlik işaretli tam sayıları tutar.     | 64 bitlik işaretsiz tam sayıları tutar. Ulong'daki u işaretsiz anlamına gelir.     |
| olası en küçük değeri -2,147,483,648'dir;     | olası en küçük değeri 0'dır;     | olası en küçük değeri 9,223,372,036,854,775,808'dir;     | olası en küçük değeri 0'dır;     |
| olası en büyük değer 2.147.483.647'dir.     | olası en büyük değer 4.294.967.295'tir.     | olası en büyük değer 9,223,372,036,854,775,807'dir.     | olası en büyük değer 18,446,744,073,709,551,615'tir.     |

| char | bool |
| :-------: | :-------: |
| 16 bit Unicode karakterleri tutar.     | Doğru veya yanlış olmak üzere iki olası değerden birini tutar.     |
| olası en küçük değeri, değeri 0 olan Unicode karakteridir; | C#'nın C ve C++ mirasından koptuğu alanlardan biridir. C ve C++'da, 0 tamsayı değeri false ile eşanlamlıydı ve sıfır olmayan herhangi bir değer, true ile eşanlamlıydı. Ancak C#'da türler eşanlamlı değildir.     |
| olası en büyük değer, değeri 65,535 olan Unicode karakteridir. | Bir tamsayı değişkenini eşdeğer bir bool değerine dönüştüremezsiniz. Doğru veya yanlış koşulu temsil etmesi gereken bir değişkenle çalışmak istiyorsanız, int değişkeni değil, bool değişkeni kullanmamız gerek.     |


| float | double |
| :-------: | :-------: 
| 32-bit işaretli floating-point value tutar.     | 64-bit işaretli floating-point value tutar.     |
| olası en küçük değeri, yaklaşık 1,5 kat 10 üzeri 45'tir;     | en küçük değeri yaklaşık 5 çarpı 10 üzeri 324'tür;     |
| mümkün olan en büyük değer yaklaşık 3.4 kat 10 üzeri 38. kuvvettir.| olası en büyük değer yaklaşık 1,7 çarpı 10 üzeri 308'dir.     |



|                 sbyte                 |                                                   byte                                                    |                 short                  |                 unshort                 |
|:-------------------------------------:|:---------------------------------------------------------------------------------------------------------:|:--------------------------------------:|:---------------------------------------:|
| 8 bitlik işaretli tam sayıları tutar. |                                   8 bitlik işaretsiz tam sayıları tutar                                   | 16 bitlik işaretli tam sayıları tutar. | 16 bitlik işaretsiz tam sayıları tutar. |
| değeri pozitif veya negatif olabilir. | Sbyte değişkenlerinin aksine, bayt değişkenleri işaretli değildir ve yalnızca pozitif sayıları tutabilir. |                   -                    | Ushort'taki u işaretsiz anlamına gelir. |
|     olası en küçük değer -128'dir     |                                        olası en küçük değer 0'dır                                         |    olası en küçük değer -32,768'dir    |      olası en küçük değeri 0'dır;       |
|    olası en büyük değer 127'dir..     |                                       olası en büyük değer 255'tir.                                       |    olası en büyük değer 32,767'dir.    |    olası en büyük değer 65.535'tir.     |

[Floating-point value nedir?](https://en.wikipedia.org/wiki/Floating-point_arithmetic#:~:text=A%20floating%2Dpoint%20number%20is,%C3%971000%20or%20145%2C000%2F100.)

[Tablo Kaynağı](https://www.techrepublic.com/article/learn-the-basics-about-c-data-types-variables/#content:~:text=Predefined%20C%23%20value%20types)

---
