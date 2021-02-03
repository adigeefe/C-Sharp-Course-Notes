using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class BasketManager
    {
        //Pythonda ki def mevzusu
        //                  Tipi
        //                  |       asagida kullanicagin sey
        //                  ↓       ↓
        public void Add(Product product)
        {
            Console.WriteLine("Success! Added to Basket: "+ product.Name);
        }
        

        public void Add2(string productName, string Description, double cost)
        {
            Console.WriteLine("Success! Added to Basket: " + productName);

        }
    }
}
