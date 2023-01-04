using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array -dizi
            string[] kurslar = new string[] { "React", "Java", "PHP" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
            //foreach dizi temelli yapıları tek tek dönmeye yarar
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Foreach bitti");
        }
    }
}
