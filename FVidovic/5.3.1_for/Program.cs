using System;

namespace _5._3._1_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Petlja for");

            Console.WriteLine("Brojevi od 0 do 9");

            for (int i = 0; i < 10; i++)
              {
                Console.Write(i+" ");
              }

            Console.WriteLine("\nNeparni veći od 1 a manji ili jednaki 20");

            for (int i = 3; i <= 20; i += 2)
            {
                Console.Write(i + " ");
            }


            Console.WriteLine("\nBrojevi od 1 do 100 djeljivi sa 5");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 )
                Console.Write(i + " ");
            }

            Console.WriteLine("\nSuma prvih 100 prirodnih brojeva");

            int zbroj = 0;
            for (int i = 1; i <= 100; i++)
            {
                zbroj += i;  
            }
            Console.Write( zbroj );

            Console.WriteLine("\nFaktorijel X");


            int faktorijel = 1;
            int broj = int.Parse(Console.ReadLine());
            for (int i = 1; i <= broj; i++)
            {
                faktorijel *= i;
                
            }
            Console.Write(faktorijel);

            Console.WriteLine("\nxxxxxxxx");

            for (int i = x; i <= x; i += x)
            {
                Console.Write(i + " ");
            }

        }

    }
}
