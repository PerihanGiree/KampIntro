using System;

namespace ClassMethotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MusteriManager musterimanager = new MusteriManager();
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Perihan";
            musteri1.Soyad = "Gire";

            musterimanager.MusteriEkle(musteri1);
           
           
        }
    }
}
