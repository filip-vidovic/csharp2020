using System;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite cijeli broj te ce ga program ispisati unatrag");
            int a = int.Parse(Console.ReadLine());
            while (a > 0)
            {
                Console.WriteLine(a % 10);
                a = a / 10;
            }
        }
    }
}
