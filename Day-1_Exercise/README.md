### Ödev 1

C# dilinde bulunan diğer veri tipleri nelerdir? (Ezberlemeyiniz, sadece araştırıp inceleyiniz.)

<details>
  <summary>Cevap</summary>

byte 
sbyte 
short
ushort
int 
uint
long
ulong 
float 
double 
decimal
char
string
boolean

</details>



____



### Ödev 2

C# dilinde "ternary operatörü" araştırınız. Ternary Operatörü bilmeyen birine yazıyla anlatmanız gerekseydi, nasıl anlatırdınız?

<details>
  <summary>Cevap</summary></br>
Şimdiii, biz şart blokları kullanıyoruz. Nedir bunlar?</br></br>
if (eğer)</br>
else if (değilse eğer)</br>
else (değilse)</br></br>
Bu şart blokları birşeyi kontrol etmemize yarıyor.</br>
Örneğin bir login (giriş yapma) işlemini kontrol edelim</br>

```c#
    // Girdilerin string olucagını söyliyelim
    string kullaniciAdi = "", sifre = "";
    // K.Adi Girmesini istiyelim
    Console.WriteLine("Kullanici Adini Girin: ");
    //Girileni kullaniciAdi stringine atıyalım.
    kullaniciAdi = Console.ReadLine();
    //Şifre Girmesini istiyelim
    Console.WriteLine("Sifreyi Girin");
    //Girileni sifre stringine atıyalım.
    sifre = Console.ReadLine();
//
// Ardından
// 
//   .--EĞER 
//   |      .--programa verdiğimiz kullanıcı adı
//   |      |        .-- Eşit ise
//   |      |        |     .-"admin" stringine
//   |      |        |     |     .--Ve
//   |      |        |     |     |  .-- Programa verdiğimiz şifre
//   |      |        |     |     |  |    .-- Eşit ise
//   |      |        |     |     |  |    |    .- "123" stringine
//   |      |        |     |     |  |    |    |         Sorgusunu yapalım
//   |      |        |     |     |  |    |    |
//   ↓      ↓        ↓     ↓     ↓  ↓    ↓    ↓
    if (kullaniciAdi == "admin" && sifre == "123")
    {
    
    //"Giris basarili" yazdir
    Console.WriteLine("Giris Basarili");
    
    }
    
    //Değilse yani bu koşullardan herhangi birisi sağlanmıyor ise
    else
    {
    
    //Hatalı girdi olduğunu belirt.
    Console.WriteLine("Kullanici adi ve ya sifre hatali");
    
    }
```

Şimdi gelelim bahsedilen operatöre (ismini unuttunuz değil mi? Bende unuttum aramızda :smile: )

Ternary Operatörü nedir? 

Valla araştırdım geldim, bu operatör bizim şart blokları ile kontrol ettiğimiz şeyleri ben tek satırda yaparım diyormuş. (Biraz iddalı sanki değil mi? ne de olsa bu kadar zamandır şart bloklarını böyle kullanıyoruz.) 

Gelin hızlıca bir inceleme yapalım.

```c#
//Yine Aynı İşlemler

    // Girdilerin string olucagını söyliyelim
    string kullaniciAdi = "", sifre = "";
    // K.Adi Girmesini istiyelim
    Console.WriteLine("Kullanici Adini Girin: ");
    //Girileni kullaniciAdi stringine atıyalım.
    kullaniciAdi = Console.ReadLine();
    //Şifre Girmesini istiyelim
    Console.WriteLine("Sifreyi Girin");
    //Girileni sifre stringine atıyalım.
    sifre = Console.ReadLine();

    //Geldik operatöre
    //Şimdi burada durum stringini tanımlamışız (gözünüz aşağıya çoktan kaymıştır :) kaymadıysa bile şuan kaymıştır :) hala kaymadıysa, kaysın :) ) ve yazdırmışız.
    //Bu demek oluyor ki şimdi birşeyi kontrol edicez bu kontrol bize bir sonuç sağlayacak ve bu sonuçta durum stringine atanıcak ardından bize sonucu yazdırıcak.
    //Burası tamam peki bu görüntü kalabalığı ne?
    //Gelin inceliyelim.
    //"durum ="den sonrasını inceliyelim.
//
//                                       .--Aynı kontroller yapılmış
//                                       |                    .--Hmm kontrolleri yapmışız, parantez içine alıp sonuna soru işareti koymuşuz.
//                                       |                    |      .---1.durum için giriş başarılı
//                       ----------------.----------------    |      |          .--2.Bir durum girdiğimizi belirtmişiz ve ayırmışız.
//                      /        |     |     |   |    |   \   |      |          |               .--2.Durum için ise giriş başarız sonucunu vermişiz.
//                      |        |     |     |   |    |   |   |      |          |               |              Yani burada ki sonucu "durum" stringine atamışız
    string durum = (kullaniciAdi == "admin" && sifre == "123")? "Giris Basarili":"Kullanici adi ve ya sifre hatali";
//  Ardından durumu başarılı veya başarız şeklinde yazdırmışız.
    Console.WriteLine(durum);
```

Ben şok, ciddi ciddi tek satırda hallettik :smile: 


</details>


____





### Ödev 3

C# dilinde "switch" yapısını araştırınız. Switch yapısını bilmeyen birine yazıyla anlatmanız gerekseydi, nasıl anlatırdınız?

<details>
  <summary>Cevap</summary>

Gelin bunu da microsoft'un dökümanlarından inceliyelim.

>Switch yapısı nedir? 

Switch yapısında tek bir ifade ile, üç veya daha fazla koşulu kontrol edeiyor ve genellikle If-Else yapısına alternatif olarak kullanılıyormuş. Örneğin, aşağıdaki ifade, verdiğimiz bir tam sayının üç değerden birine sahip olup olmadığını kontrol ediyormuş

```c#
using System;

public class Example
{
    public static void Main()
    {
        int caseSwitch = 2;

        switch (caseSwitch)
        {
            case 1:
                Console.WriteLine("Case 1");
                break;
            case 2:
                Console.WriteLine("Case 2");
                break;
            default:
                Console.WriteLine("Default case");
                break;
        }
    }
}
```

Bize böyle bir kod verilmiş. Bu sefer tek tek inceliyelim.

Main'de caseSwitch tam sayısını 2'ye eşit olarak tanımlamışız.

```c#
int caseSwitch = 2;
```

Ardından bu template içinde birşeyler yapmışız.</br>
caseSwitch şeklinde bir tam sayı atamıştık. Switch yapısına bu tamsayıyı vermişiz. Bu demek oluyor ki ya bu tam sayıyı kullanarak bana çıktı vericek ya da bu tam sayıyı kullanarak işlem yapıcak.

```c#
switch (caseSwitch)
        {

        }
```

Bütün olarak incelersek. case 1:, case2: yazmış onların içine de stringler yazıp konsolda yazdırmak istemişiz. ve ardından break yazmışız.</br>
Bu demek oluyor ki bizim verdiğimiz tam sayıyı kullanarak bize çıktı veriyor. Peki nasıl?</br>


```c#
switch (caseSwitch)
        {
            case 1:
                Console.WriteLine("Case 1");
                break;
            case 2:
                Console.WriteLine("Case 2");
                break;
            default:
                Console.WriteLine("Default case");
                break;
        }
```

Gelin bu kod bloğunu bi çalıştıralım.

![](https://i.imgur.com/vQ8swTj.png)

Bize case2 sonucunu verdi. Eğer verdiğimiz tamsayıyı 1 yaparsak da Case 1 çıktısı veriyor.</br>

Break'i de halen anlamadıysak hemen bi google'a soralım.

![](https://i.imgur.com/2AVXkRR.png)

Yani burdan şunu çıkarabiliriz.

![](https://i.imgur.com/SIyRe9L.png)

Orda birde default var o ne peki?

Microsoft dökümanlarına gittiğimizde bozuk bir çeviri ile bize bu verilmiş.

![](https://i.imgur.com/FGgKK6k.png)

Yani default'dan da anlayacağımz şey verdiğimiz tam sayı 3 olursa. Default Case döndürücek. 

Doğrumu anladık?

![](https://i.imgur.com/iTtHizA.png)

:100: 


</details>

____



### Ödev 4

C# dilinde "while döngüsünü" araştırınız. While döngüsünü bilmeyen birine yazıyla anlatmanız gerekseydi, nasıl anlatırdınız?

<details>
  <summary>Cevap</summary>

Bunu da benim dökümanlardan inceleyelim :smile: </br> While dönügüsü nedir?</br> While döngüsü ile bir işlem yaparak anlatmak istiyorum.</br> Ama öncelikle snippet ile bize verilen taslağa bir bakalım.

![](https://i.imgur.com/FufIG22.png)

Gayet basit bir şekilde while yazıp bir koşulu kontrol ediyoruz true ya da false.</br> 

Eğer bu döngünün içine birşey yazdırırsam;

```c#
while (true)
{
    Console.WriteLine("Sonsuz");
}
```
Progrma bize sonsuza kadar "Sonsuz" yazısını yazıcak.

Tabi ki sonsuza kadar gereksiz bir işlem yapmasını istemiyoruz. Birde gerekli bir işlem yaptıralım, yapacağımız işlem, bir yazıyı koşula göre yazdırmak olsun.

```c#

//Bir i tam sayısı belirliyelim bu tam sayı 1 olsun.
int i = 1;

//Eğer i 10'dan küçük eşitse aşağıdaki işlemi bir kere yap böylelikle koşulumuz tamamlana kadar bu döngü devam edicek.
while (i<=10)
{
    Console.WriteLine("Şuanki sayı:" + i);
    i++;
}
```

Daha fazla detaya girmek istemiyorum çünkü zaten for'da açıklamıştım, tek farkı while içinde tam sayı oluşturup işlemler yapabiliyoruz.

</details>

____


### Ödev 5

Bir adet quiz sorusu yazınız.

Bu soru bugüne kadar öğrendiklerimizi içermelidir.

Doğru cevabı belirtmeyiniz.

<details>
  <summary>Cevap</summary>
  
For döngüsünde length ne anlama gelir?
  
</details>

____

### Ödev 6

Herhangi bir e-ticaret sistemine giriniz.

Genellikle bir e-ticaret sistemine girdiğinizde ürünler listelenir. Siz de Urun (Product) isimli bir class oluşturup, oluşturduğunuz bir kaç ürünü bir diziye ekleyiniz.

Ürünlerinizi for, foreach ve while döngüleri ile ayrı ayrı listeleyiniz.

<details>
  <summary>Cevap</summary>

+Yapıldı</br>
Kod eklenicek.

</details>
