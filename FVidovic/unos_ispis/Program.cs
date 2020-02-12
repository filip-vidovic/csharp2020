using System;

namespace unos_ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Unesi 10 prirodnih brojeva i ispiši ih");

            int[] brojevidodeset = new int[10];   // int tipa niz imena brojevidodeset, stvaranje objekta int sa 10 elemenata

            for (int i = 0; i < brojevidodeset.Length; i++)  //sve pod ovom petljom se ponavlja onoliko puta koliko petlja traži
            {                                                          //ova petlja trazi da se od 0 dodaje +1 dok se ne dođe do 9
                Console.WriteLine(" Unesi {0}. broj:",i+1);                          //jer je brojevidodeset.Lenght  10 sto znamo 
                brojevidodeset[i] = int.Parse(Console.ReadLine());              //jer smo ga definirali kao "new int [10]"

            }

            //ispis
            Console.WriteLine("Pravilno");
            for (int i = 0; i < brojevidodeset.Length; i++)
            {
                Console.Write(brojevidodeset[i] + " ");
            }

            Console.Write("\n "); //Prelaz u drugi red, stilistički
            Console.WriteLine("Unazad");
            for (int i = brojevidodeset.Length-1; i >= 0; i--)
            {
                Console.Write(brojevidodeset[i] + " ");
            }

            
            Array.Sort(brojevidodeset);
            Console.Write("\n ");
            Console.WriteLine("Sortirani");

            for (int i = 0; i < brojevidodeset.Length; i++)
            {
                Console.Write(brojevidodeset[i] + " ");
            }


            Array.Reverse(brojevidodeset);
            Console.Write("\n ");
            Console.WriteLine("Sortirani unatrag");

            for (int i = 0; i < brojevidodeset.Length; i++)
            {
                Console.Write(brojevidodeset[i] + " ");
            }


            Array.Reverse(brojevidodeset);
            Console.Write("\n \n \n \n ");
            Console.WriteLine("Sortirani");
            for (int i = 0; i < brojevidodeset.Length; i++)
            {
                Console.Write(brojevidodeset[i] + " ");
            }

            Console.WriteLine(" \n Upiši broj koji želiš pronaći");
            int b = int.Parse(Console.ReadLine());
            int nadjib = Array.IndexOf(brojevidodeset, b);    //indexof vraca -1 ako ne nađe vrijednost koju traži
                                                               //u ovom slucaju trazi b

            if (nadjib < 0)                                 
            {
                Console.WriteLine("Program ne može naći broj" + b);
            }
            else
            {
                Console.WriteLine("Broj " + b + " nalazi se na {0} mjestu", nadjib+1);
            }








        }
    }
}
