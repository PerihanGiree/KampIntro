using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)  
        {
            Console.WriteLine("Musteriler Eklendi" +musteri.Ad);
        }
         
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müsteri silindi");
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Muşteriler listelendi.");

        }
    }
}
