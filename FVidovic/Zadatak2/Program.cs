using System;
using System.Collections.Generic;
using System.Collections;


namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pišite rijeći dok ne upišete rijec kraj");
            List<string> a = new List<string>();
            List<string> b = new List<string>();
            List<string> c = new List<string>();
            List<string> o = new List<string>();

            string rijeci = "";
            while (rijeci != "kraj")
            {
                rijeci = Console.ReadLine();
                if (rijeci.StartsWith('a') || rijeci.StartsWith('A'))
                {
                    a.Add(rijeci);
                }
                else if (rijeci.StartsWith('B') || rijeci.StartsWith('b'))
                {
                    b.Add(rijeci);
                }
                else if (rijeci.StartsWith('C') || rijeci.StartsWith('c'))
                {
                    c.Add(rijeci);
                }
                else
                {
                    o.Add(rijeci);
                }
            }

            Console.WriteLine("A:");
            a.ForEach(x =>
            {
                Console.WriteLine(x);
            });

            Console.WriteLine("B:");
            b.ForEach(x =>
            {
                Console.WriteLine(x);
            });

            Console.WriteLine("C:");
            c.ForEach(x =>
            {
                Console.WriteLine(x);
            });

            Console.WriteLine("Ostalo:");
            o.ForEach(x =>
            {
                if (x!="kraj")
                Console.WriteLine(x);
            });
        }
    }
}
