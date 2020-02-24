using System;

namespace _7_3_krug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite radijus kruga u cm");

            double radijus = double.Parse(Console.ReadLine());

            Console.WriteLine("Od kruga radijusa {0}cm izračunali smo površinu od {1}cm2 i opseg od {2}cm", 
                radijus, Povrsina(radijus), Opseg(radijus));
        }

        private static double Opseg(double radijus)
        {
            return 2 * radijus * Math.PI;
        }

        private static double Povrsina(double radijus)
        {
            return radijus * radijus * Math.PI;
        }
    }
}
