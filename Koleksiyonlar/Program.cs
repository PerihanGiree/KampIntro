using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler
 =new string[] { "Engin" ,"Murat","Kerem","Halil"};
            Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string>() { "Engin", "Murat", "Kerem" };
            Console.WriteLine(isimler2[0]);
            isimler2.Add("Perihan");
            Console.WriteLine(isimler2[3]);
            

        }
    }
}
