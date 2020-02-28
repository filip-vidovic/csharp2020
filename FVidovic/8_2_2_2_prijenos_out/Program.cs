using System;

namespace _8_2_2_2_prijenos_out
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a;
            inicijaliziraj(out a);
            Console.WriteLine("a je jednako="+a);
        }

        private static void inicijaliziraj(out int a)
        {
            a = 55;
        }
    }
}
