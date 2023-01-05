using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager 
    {//Method injection
        public void BasvuruYap( IKrediManager krediManager,List<ILoggerService>  loggerService  )
        {
            //Basvuru bilgileri degerlendirme
            krediManager.Hesapla();
            foreach (var logger in loggerService)
            {
                logger.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }
        
    }
}
