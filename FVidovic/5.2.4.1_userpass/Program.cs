using System;

namespace _5._2._4._1_userpass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ime korisnika");
            string user = Console.ReadLine();
            Console.WriteLine("Unesite lozinku korisnika");
            string pass = Console.ReadLine();

            if (user=="cara" && pass=="bambina")
            {
                Console.WriteLine("Login uspješan");
            }
            else
            {
                Console.WriteLine("Login neuspješan");
            }
        }
    }
}
