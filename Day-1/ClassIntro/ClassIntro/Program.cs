using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni="Can";
            kurs1.IzlenmeOrani=50;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Piton";
            kurs2.KursEgitmeni = "LuNizZ";
            kurs2.IzlenmeOrani = 110;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Heçkır Olma Kursu";
            kurs3.KursEgitmeni = "Heçkırlar";
            kurs3.IzlenmeOrani = 1;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi +"\n"+ kurs.KursEgitmeni +"\n"+ kurs.IzlenmeOrani + "\n \n");
            }

            
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
        public string test { get; set; }
    }
}   
