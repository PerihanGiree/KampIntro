using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            ILoggerService dataBaseService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            //Interface onu ımplemente eden classın referansını tutabilir .

            BasvuruManager basvurManager = new BasvuruManager();
             basvurManager.BasvuruYap(konutKrediManager, new List<ILoggerService> { smsLoggerService,dataBaseService});


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager ,konutKrediManager,tasitKrediManager};

            basvurManager.KrediOnBilgilendirmesiYap(krediler);
        }

    }
}
