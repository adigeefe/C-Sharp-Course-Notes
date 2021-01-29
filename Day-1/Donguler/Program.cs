using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi
            string[] kurslar = new string[] {"Yazılım gelistirme", "programlamaya başlangıç",
                "Java"};
            
            for (int i = 0; i<kurslar.Length; i++)//i+=2 olarakda olabilir
            {
                Console.WriteLine(kurslar[i]);
            }



        }
    }
}
