using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Cost = 15;
            product1.Description = "Amasya apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Cost = 80;
            product2.Description = "Diyarbekir watermelon";

            //Array bir veri tepinde ne kadar data eklersen o yapıyı tutan yapıdır.
            //Dizi
            Product[] products = new Product[] { product1, product2 };

            //  -> Gezdiğin elemenların sayısı kadar döndürür, var yazsanda olur  
            //                   .- her getirdiği elemanı biyere atamak zorunda x desende olur 
            //                   |      .-products listesinde her bir elemanı tek tek gez
            //                   ↓     ↓
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Cost);
                Console.WriteLine(product.Description);
                Console.WriteLine("-------------------");


            }

            Console.WriteLine("--------Methods--------");
            //instance - örnek
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);
            //              ↑
            //              `--Stok adedi özelliği gelirse, tek satırla işi bitirirsin
            Console.WriteLine("-------Encapsulation--------");
            //              ,--Stok adedi özelligi gelirse, tüm ürünleri tek tek degistirmek zorunda kalrısın
            //              ↓    
            basketManager.Add2("Milk", "Delicious Milk", 12);
            basketManager.Add2("Watermelon", "Diyarbekir Watermelon", 80);





        }
    }
}
