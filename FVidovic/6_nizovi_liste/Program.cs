using System;

namespace _6_nizovi_liste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] niz = new int[3];
            niz[0] = 55;
            niz[1] = 66;
            niz[2] = 77;
             // niz[3] = 88; ovaj ima samo 3 elementa pa ovaj necemo

            for ( int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]);
            }
            
            foreach (int item in niz)
            {
                Console.Write(" " + item);
            }




        }
    }
}
