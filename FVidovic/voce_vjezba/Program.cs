using System;
using System.Collections.Generic;

namespace voce_vjezba
{
    class Program
    {
        static void Main(string[] args)
        {
            Jabuka a1 = new Jabuka(8);
            Jabuka a2 = new Jabuka(6);
            Banana b1 = new Banana(10);
            Banana b2 = new Banana(12);
            Naranca n1 = new Naranca(5.5);
            Naranca n2 = new Naranca(5);

            Jabuka[] jabukas = new Jabuka[2] { a1, a2 };

            List<Banana> bananas = new List<Banana>();

            bananas.Add(b1);
            bananas.Add(b2);

            
        }
    }
}
