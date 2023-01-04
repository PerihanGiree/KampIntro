using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Perihan";
            int yas = 24;

            Kurs kurs1 = new Kurs();//Yeni kurs tanımlama
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Perihan ";
            kurs1.IzlenmeOrani = 58;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Sezer";
            kurs2.KursAdi = "React";
            kurs2.IzlenmeOrani = 88;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Hilmi";
            kurs3.IzlenmeOrani = 48;

            //  Console.WriteLine(kurs3.KursAdi + ":" + kurs3.IzlenmeOrani);
            //Türü başa yazıyoruz int ,string ,kurs ...
            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ ":"+kurs.Egitmen+":"+kurs.IzlenmeOrani);
            } 
            Console.WriteLine("Hello World!");
        }
    }
    class Kurs
    {
  //prop tab tab ile şablonu oluşturur.
  //Kurs değişkenimiz proplarda özelliklerimiz değişken
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
