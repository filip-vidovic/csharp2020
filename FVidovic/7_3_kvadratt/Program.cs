using System;

namespace _7_3_kvadratt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kvadriramo broj");

            int broj = int.Parse(Console.ReadLine());

            Console.WriteLine("broj {0} kvadriran je {1}", broj, Kvadrat(broj));

            Console.WriteLine("broj {0} na treću je {1}", broj, Kub(broj));

            Console.WriteLine("broj {0} na četvrtu je {1}", broj, nacetrvrtu(broj));
        }

        private static int nacetrvrtu(int broj)
        {
            return Kub(broj) * broj;
        }

        private static int Kub(int broj)
        {
            return Kvadrat(broj) * broj;
        }

        private static int Kvadrat(int broj)
        {
            return broj * broj;
        }
    }
}
