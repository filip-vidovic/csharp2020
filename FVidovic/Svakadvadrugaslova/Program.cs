using System;

namespace Svakadvadrugaslova
{
    class Program
    {
        static void Main(string[] args)
        {
            //U testu. napraviti program koji ispisuje svaka dva slova pa dva slova izbaci, također izbaciti razmake
            Console.WriteLine("Upišite text");
            string txt = Console.ReadLine();
            txt=txt.Replace(" ","");
            Console.WriteLine(txt);
            Console.WriteLine(txt.Substring(0, 2));


        }
    }
}
