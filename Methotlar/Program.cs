using System;

namespace Methotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tekrar tekrar kullanılabilen kod tekrarları
            Console.WriteLine("Hello World!");
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Muğla Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urunn in urunler)
            {
                Console.WriteLine(urunn.Adi + ":" + urunn.Fiyati);

            }
            Console.WriteLine("--------------------Methodlar---------");


            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            //encapsulatiion olmadığı için düzensiz ve gereksiz zaman ve iş gücü kaybı
            sepetManager.Ekle2("Armut", "Yeşil", 12,10);
            sepetManager.Ekle2("Ayva", "Yeşil", 12,6);
            sepetManager.Ekle2("Muz", "Yeşil", 12,5);



        }
    }
}
