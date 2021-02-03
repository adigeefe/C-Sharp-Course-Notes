# Methodlar

### Neden Metot Kullanıyoruz?

Kampın ilk gününden ne için metotları kullandığımızı zaten biliyoruz.
Tekrar tekrar kullanılabilirliği sağlayan bir ortam sunuyor. Bu da temelde "Don't Repeat Yourself" ve clean code(temiz kod yazma) prensibine dayanır.


Asıl amaç, bir projede yazdığımız bir kodu 5-6 sayfada kullandığımızda ve sonradan bu projeye bir güncelleme geldiğinde tek tek 5-6 sayfayı bulup hepsini tek tek değiştirme gibi bir sorunu ortadan kaldırmak.

<details>
  <summary>Yahu güzel kardeşim sen ne anlatıyon? :)</summary></br>
Şimdi kullandığımız bir e-ticaret sistemini düşündük sepete ekleme diye bi özellik var. Bu özellikde ürünün altında, üstünde sepete ekle yazan bi buton var basıyosun bu butona hooop sepete eklendi. O butonun arkasında bi kod var, bastığımız an o kod çalışıyor. Başka ürünlerde, sayfalarda, size gönderilen maillerde (ilgilenebileceğin ürünler vs.) de bu butondan kullanılıyor. Bu butonların tümü için tek tek kod yazarsa bir programcı bir güncelleme geldiğinde, bir özellik geldiğinde tek tek değiştirmek zorunda kalır, e tabi ki kimse bunu yapamaz, yapmaz. Kolaylık da burda ortaya çıkıyor ben buton için bir metot oluşturuyorum ardından o metodu başka yerlerde kullanıyorum ve tek tek tüm butonları değiştirmek zorunda kalmıyorum. Sadece o metotda ki kodu değiştirmem yeterli.

</details></br>

Metotlar için bir proje oluşturalım, oluşturduktan sonra üstünde sağ tıklayıp class ekliyelim.
E-Ticaret sisteminde olduğu gibi bir sepet-manager oluşturalım. Bunun amacı sepeti kontrol etmek vs. olucak. Aynı şekilde birde product isminde class ekliyelim.</br></br>
Bir e-ticaret sisteminde bir ürüne girdiğimizde karşımıza
```c#
string urunAdi = "Elma";
double fiyat= 15;
string aciklama = "Amasya Elması";
 ```

gibi ürün özellikleri gelicektir. Almak istediğimiz ürün elma fakat bu şekilde elma için birden fazla değişken oluşturuyoruz, e böyle olunca iş karman çorman bir hal alıyor. Bunların 3'ü zaten bir ürün bunları ben tek tek tanımlamak istemiyorum, o zaman class kullanıcağım. Class ile bunları tek başına bir ürün nesnesi olarak oluşturalım. Bu kadar detay bence yeterli :smile: 

Classı oluşturduktan sonra prop (property'den geliyor) yazıp TAB+TAB ile taslağımın gelmesini sağlıyorum ve Id, fiyat ve açıklamaların özelliklerini girelim. Bunlar adından da anlaşılacağı gibi özellik, ürünün isminin özelliği, fiyatının özelliği vs.
```c#
class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
}
```

Tamda istediğimizi yaptık, artık ürün için, ürünü anlatan bir veri tipi mevcut. Normalde nasıl yaptığımızı yukarıda baktık zaten. Bunları tek tek eklemek hoş değil. "Ya bana hoş ben böyle yapıcam" dedim ve bunları yazdırma kısmına geldiğimde, dizilerde karşıma bir sorun çıktı. Ben bunları dizi ile yazdırmak istiyorum, string için bir dizi oluşturdum fakat ürünün fiyatı string değil, tam sayı peki bunu nasıl yapıcam derken yapamadığımı farkettim.</br>
Main'e dönüp classımızı kullanmak için tanımlama yapalım. İlk gün bu tanımlamaya bakmamıştık. </br>
```c#
//    .--Ürün tipinde
//    |       .-- Elma da olabilir 
//    |       |      .--.-----.--Class tanımladığımız için bunu yazıyoruz.
//    ↓       ↓      ↓  ↓     ↓
    Product product1 = new Product();
    //Şimdi bir ürün oluşturduk.
    
    //        ↓---Classlarda kullanmıştık
    product1.Name = "Apple";
    product1.Price = 15;
    product1.Description = "Amasya apple";
    
    //Nasıl stringlerden birden fazla oluşturuyoruz bu ürünlerden de birden fazla oluşturabiliriz. Aynı şekilde;
    
    Product product2 = new Product();
    product1.Name = "Watermelon";
    product1.Price = 80;
    product1.Description = "Diyarbakır watermelon";
    
    //Bunları yazdıralım. Normalde arrayi bu şekilde oluşturuyorduk.
    //string meyveler[] = new string[] {"Elma", "Karpuz"};
    
    //Classlar için de bu şekilde
    Product[] products = new Product[] {product1, product2};

        //Product (veri tipi) için -> Type-safe/tip güvenli, Burda da "ben neyle çalışıcağımı bilmek istiyorum" diyor. Aslında var yazarsak da olur  
        //var ne yapıyor? Tek tek dolaşırken bizim elemanımız Product tipinde olduğu için onu Product yapıyor. var yazıp üstüne geldiğimizde görebiliriz. 
        //                   .- her getirdiği elemanı biyere atamak zorunda x desende olur 
        //                   |      .-products listesinde her bir elemanı tek tek gez
        //                   ↓      ↓
        foreach (Product product in products)
        {
           Console.WriteLine(product.Name);
           Console.WriteLine(product.Price);
           Console.WriteLine(product.Description);
           Console.WriteLine("-------------------");
        }
```
İleride bunları "new" değilde veri kaynağından nasıl çekiceğimizi göreceğiz.[ Mantığını zaten konuştuk. ](https://github.com/adigeefe/C-Sharp-Course-Notes/tree/main/Day-1/Donguler#user-content-liste-nedir:~:text=%2F%2FTan%C4%B1mlama%20olarak%20da%20b%C3%B6yle%2C,string%5B%5D%20kurslar%20%3D%20%20kurslariGetir()%3B)
</br> Yazdırmaya çalıştığımızda sonuç;
![](https://i.imgur.com/KbpckrG.png)</br>
:+1: 

-------------

Classların diğer kullanımına geliyoruz. Engin hocanın dersin başında oluşturduğu SepetManager'a geri dönelim, bir classın sonunda bu tarz bir manager yazısı bize bir operasyon belirtiyor. Nasıl bir operasyon bunlar?</br>
Sepetle ilgili tüm işlemler, mesela sepete ekle, sepetten çıkar, sepet toplamı vs. Sepet manager yerine müşteriyle ilgili operasyon belirten bir classda oluşturabilirdik.</br>
Bir metodu nasıl oluşturduğumuza bakalım. Aynısını pythonda da yapmıştık.
```c#
//pythonda ki def ile aynı
//          naming convention'dan dolayı add'in baş harf büyük
public void Add()
{
    Console.WriteLine("Added!");
}
```

Main'e dönüp Add metotunu çağıralım.
```c#
static void Main(string[] args)
{    
    //clasımızı çağıralım burda yaptığımız şey bir class instance'ı oluşturmak.
    //instance - örnek
    SepetManager sepetManager = new SepetManager();
    
    sepetManager.Add();
    sepetManager.Add();
    sepetManager.Add();
}

```
Add Methodunu istediğimiz kadar farklı yerlerde çağırabiliriz. Eğer "Added!" mesajını düzenlemek istersek tek bir yerden düzenlememiz yeterli olucaktır.</br></br>
Biraz daha detaylandıralım. E-ticaret sistemine geri dönelim ürünlerin olduğu bir sayfaya geldiğimizde karşımıza alt alta ürünler çıkıcakır. Bir ürüne gelip sepete ekle butonuna bastığımızda o ürünü sepete eklediğimizi tabi ki söylememiz gerekiyor. Burda da işin içine parametreli metotlar giriyor.</br>
Aradaki farka bakalım
```c#
//                    .--Tipi
//                    |        .-- Aşağıda kullanıcağımız isimlendirme.
//                    ↓        ↓
    public void Add(Product product)
    {
//                              .-- Ürünün adını da bu şekilde çağırıyoruz.
//                              ↓
        Console.WriteLine( product.Name +"Added!");
    }
```

Main'e döndüğümüzde Ekle'lerin (Add) bize kızdığını görüyoruz. Üstüne geldiğimizde de "There is no arg. given that corresponds.." bu da "hocam senin sepet managerında ki ürün metotu bir ürün istiyor, bana hangi ürünü ekleyeceğini söyle de ben manager'a o ürünü gönderiyim o ekler çıkarır bişiler yapar. (Ben butonum işimi yaparım üstüme basıldığında sepetManager'a 'hocam bu arkadaş bu ürünü sepete eklicekmiş' der ve sepetmanager'a yönlendiririm)" diyor.</br> Boş yapmamak gerekirse hangi ürünü ekliyeceğimizi ver diyor.
![](https://i.imgur.com/w6OBIfk.png)</br>
Bunu da

```c#
static void Main(string[] args)
{    
    SepetManager sepetManager = new SepetManager();
    
    sepetManager.Add(product1);
    sepetManager.Add(product2);
}

```
Çalıştırdığımızda</br>
![](https://i.imgur.com/WQk6fJp.png)</br>
(Yazım biraz farklı olmuş programda sadece yazı farklı mantık aynı ve aynı zamanda şunu unutmayalım elimizdeki ortam şuan için bu yani ardı ardına sepete ekle tuşuna bastığını düşüyoruz.)</br>
Engin Hocam sağolsun zordan kolay yapıyor ve hesap makinasına gidiyoruz :smile:
Add new project deyip matematik projesi oluşturalım.


### Parametreli Methodlarla Çalışmak

4 İşlem classı oluşturup içine geldiğimizde

```c#
//İki sayıyı toplamak istiyorum.
//Bunun için parametreye ihtiyacımız var.
//Toplayacağımız sayılar (num1, num2) olsun.

//"Void" git şunu yap demek, biryere birşey yaz, git biryere kayıt yap vs. demek.
//Fakat burda sonuç olarak bir sayı istiyoruz ve bu yüzden nasıl bir veri döndürmek istiyorsak o tipi yazmamız gerek.

    public void Topla(int num1, int num2)
    {
       int addition = num1 + num2;
       Console.WriteLine("Total: " + addition);
    }

    
    //ya da
    
    // return num1 + num2;
}
```
program.cs'ye (Main)'e dönelim

```c#
        static void Main(string[] args)
        {
            FourOperations fouroperations = new FourOperations();
            fouroperations.Topla(5, 6);
        }
```

Çıktımız ise
![](https://i.imgur.com/febVf4w.png)</br>:+1:</br>
Burada bir detayımız var. Metotlar projesine döndüğümüzde alternatif bir ekleme oluşturalım ismi Ekle2 olsun ve yaptıklarımızın benzerini yapalım.</br> 
![](https://i.imgur.com/pZep8CV.png)</br>
Main'de de</br>
![](https://i.imgur.com/ZDvNPJo.png)</br>

Bu bize aynı önceki yöntemle yaptığımız durumu sağlıyor fakat bu yöntemi neden kullanmamamız gerek, neden?</br>
2 Ay sonra sistemde değişiklik kararı alındı stok durumu eklenicek, yapacağım şey;</br>
![](https://i.imgur.com/fQFi6ll.png)</br>
program.cs'ye gelelim.</br>
Patladık...</br> Çünkü tüm sayfalara tek tek yüzlerce ürün için stok adedi eklememiz gerek.</br>![](https://i.imgur.com/HvNAoB2.png)</br></br>
İlk yöntem ile nasıl yaparız dersek de yapacağımız tek şey stok adedi eklemek olucak.</br>
![](https://i.imgur.com/UgHMKRW.png)</br>
Bu olaya da encapsulation deniyor.



### Default Parametreli Metotlarla Çalışmak

```c#
static void Main(string[] args)

{
    var result = Add2(20); //50 Dönmesini bekleriz.
    Console.WriteLine(result);
}

public int Add2(int num1, int num2=30) // Eğer number 2 verilmez ise default değer olarak 30'u kullan.
{
    var result = num1 + num2;
    return result;
}
```
> Not: num1 için default değer ayarlanıp num2 bırakılamaz. Default değerler her zaman methodun en sonundan başlamak zorunda.
Aynı şekilde num1 ve num2'ye aynı anda da verilebilir.

### Challenge : Ref Keyword İle Çalışmak

[Bu challange ödevlerden geliyor](https://www.youtube.com/watch?v=rSsrJu5dWec&list=PLqG356ExoxZU5keiJwuHDpXqULLffwRYD&index=25) :smile: 

#### Soru:

```c#
static void Main(string[] args)
{
    int num1= 20;
    int num2= 100;
    var result = Add3(num1,num2)
    
    
    Console.WriteLine(result);
    Console.ReadLine();
}

static int Add3(int num1, int num2)
{
    return num1 + num2;
}

```
gibi bir programımız var. Aynı programda ufak değişiklikler yapılarak bize aşağıdaki program veriliyor.
```c#
static void Main(string[] args)
{
    int num1= 20;
    int num2= 100;
    var result = Add3(num1,num2);
    
    
    Console.WriteLine(result);
    Console.WriteLine(num1);
    Console.ReadLine();
}

static int Add3(int num1, int num2)
{
    num1 = 30;
    return num1 + num2;
}

```

Soru: num1 için ne döndürür?


<details>
  <summary>Benim cevabım</summary>

```
Benim cevabım 20 döndüreceği yönünde sebebi ise num1'i 30 tanımlarken metod içinde tanımalama yaptık.
Programın, num1'i metod içinde tekrar vermemizin sebebini bu değeri sadece bu metod için kullanacağımızı yorumlayıp ona göre işlem yapmasını bekliyorum. 
```
</details>

<details>
  <summary>Cevap</summary>

Program bize 20 döndürür. Çünkü biz burada "değer tipler" ile çalışıyoruz. Değer tipler ile referans tiplerin farkını artık yavaş yavaş öğrenmemiz gerekiyor. Değer tiplerde mevzu tamamen "değişkenin tipi" ile ilgilenir.
Yani?


```c#
    int num1= 20;
    int num2= 100;
    var result = Add3(num1, num2); 
    //Add3'e num1 gönderdiğimde aslında buraya num1 gitmiyor num1'in değeri gidiyor.
    //Biraz daha açıklayıcı olmak gerekirse biz bu num1 dediğimiz yerde num1'i önceden 20 atadığımız için program geliyoooor ve num1'in yerine şak diye 20 yi koyuyor.
    // Örnek -> var result = Add3(20, 100);
    //Ardından Add3 için num1 ile hiçbir işi kalmıyor
```
Güzel challange fakat ben method içinde num1'i değiştirirsem yukarda da değişsin istiyorum onu n'apcaz hacı?. Dersenizdeee işin içine "ref" keywordü giriyor. Yani tam olarak şunu yapmamız gerekiyor.
Method içine gelip --↓
```c#
static int Add3(ref int num1, int num2)
{
    num1 = 30;
    return num1 + num2;
}
```
Main içinde de ufak bir değişiklik gerekiyor.

```c#
var result = Add3(ref num1, num2);
```
Dememiz yeterli olucak ve bu şartlarda num1'i 30 olarak alıcaktır.

Özetle gidiyoruz, adı üstünde ref'erans alıyoruz.

</details>



### Out Keyword ile Çalışmak 

```c#
//ref yerine out vermemiz gerekiyor.
//Peki fark ne?
//ref'de num1'i mutlaka önceden set etmeniz gerekir. out'da böyle bir zorunluluk yok.
var result = Add3(out num1, num2);
```

### Method Overloading



### Ek Notlar

[Dersde aldığım bir kaç not](https://youtu.be/1j68gb1-qOw?t=8213)

int,dec,mal,float,double,bool = değer tip 
array, class,interface = referans tip


![](https://i.imgur.com/g6miTvh.png)

Arraylar referans tipdir

Sayılar 1 in ref numarası sayılar 2 nin referans numarasına eşittir

![](https://i.imgur.com/nbAkc8s.png)

![](https://i.imgur.com/fyVed87.png)

Garbage Collector 101 adresini kimse kullanmadığı için çöpe atıyo
![](https://i.imgur.com/mpqqFzn.png)
