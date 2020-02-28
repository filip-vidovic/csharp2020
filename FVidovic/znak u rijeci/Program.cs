using System;

namespace znak_u_rijeci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi rijec i jedan znak iz rijeci da provjerimo koliko puta se ponavlja");
            string rijec = Console.ReadLine();
            string znak = Console.ReadLine();
            int brojznakova = 0;

            while (rijec.IndexOf(znak) != -1)
            {
                brojznakova++;
                rijec.Substring(rijec.IndexOf(znak)+1);
            }
            Console.WriteLine($"broj znakova  {znak} u recenice je {brojznakova}");





            brojznakova = 0;
            for (int i = 0; i < rijec.Length; i++)
            {
                if (rijec[i] == char.Parse(znak))
                {
                    brojznakova++;
                }

            Console.WriteLine($"broj znakova  {znak} u recenice je {brojznakova}");

            
            }
        }
    }
}
