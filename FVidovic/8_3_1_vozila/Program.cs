using System;

namespace _8_3_1_vozila
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static klasa - DOSEG  varijabli");

            Console.WriteLine("Suma 7.8 + 15.8 je: " , +MojStatic.zbroj(broj1: 7.8, broj2: 15.8));
            Console.WriteLine("Kub 3.0 je: ", +MojStatic.kub(broj1: 3));
            Tocka t1 = new Tocka(x:0,y:0);
            Tocka t2 = new Tocka(x: 0, y: 2);
            Tocka t3 = new Tocka(3, 4);

            Crta c1 = new Crta(Tocka1: t1, Tocka2: t2);
            Console.WriteLine("Duljina crte c1 je:" +c1.Duljina); 


            Console.WriteLine("Udaljenost točaka 0,0 i 0,2 je 2?: ", +MojStatic.udaljenostocaka(t1,t2));
        }
    }
}
