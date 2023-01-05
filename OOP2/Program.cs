using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Perihan";
            musteri1.Soyadi = "Gire";
            musteri1.TcNo = "11111111111";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "6489";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "5505";


            Musteri musteri3 = new GercekMusteri();

            Musteri musteri4 = new TuzelMusteri();
            //Musteri classı hem gercek kısı referansı hem tuzel kısı referansı tutabılıyor..
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(musteri1);
            customerManager.Add(musteri2);


        }
    }
}
