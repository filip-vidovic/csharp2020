using System;

namespace _7_2_3_KSuKW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi koliko KS želite prebaciti u KW");
            double ks = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}KS je {1}KW", ks, Kw(ks));
                
        }

        static double Kw(double ks)
        {
              return ks * 0.736;   
        }
    }


}
