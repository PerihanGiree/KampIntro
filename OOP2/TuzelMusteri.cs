using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{//miras inheritance  tuzel musteri bir müsteridir

    //Müsteri içindeki tüm özellikler tüzelde de var kabul edilir.. Tüzel miras alır Müsteri den
    class TuzelMusteri:Musteri
    {
      
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
