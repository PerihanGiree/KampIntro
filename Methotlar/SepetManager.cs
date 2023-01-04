using System;
using System.Collections.Generic;
using System.Text;

namespace Methotlar
{
    class SepetManager
    {
        //manager dal operasyon tutuyor demek function 
        public void Ekle(Urun urun)//İlk kısım tipi diğer kısım eklenecek öğe
        {
            Console.WriteLine(" Tebrikler.Sepete " + urun.Adi+  "eklendi.");
        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi:" + urunAdi);
        }
    }
}
