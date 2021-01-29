using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do not repeat yourself
            /*
             This is an crazy yorum satırı bro
             */
            //değer tutucu ->alias
            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);
            int ogrenciSayisi = 3200;
            double faizOrani = 1.86421333;
            bool girisyapildimi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }
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
}