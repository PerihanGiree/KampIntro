using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(8, 10);
            dortIslem.Topla(4000, 8000);
        }
    }
}
