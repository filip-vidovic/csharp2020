using System;
using System.Collections;

namespace rastavitistringnaliste
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //napraviti 3 liste, u jednu spremiti svaku rijeć koja pocinje na a, u drugu sprmeiti 
            //svaku koja pocinje na i a u trecu sve ostale


            //Ne radi, zašto?,0

            string txt = Console.ReadLine();
            Console.WriteLine(txt);
            ArrayList a = new ArrayList();
            ArrayList i = new ArrayList();
            ArrayList o = new ArrayList();
            string[] rijec = txt.Split(" ");

            for (int u = 0; u < rijec.Length; u++)
            {

                if (rijec[u].Substring(0, 1) == ("a") || rijec[0].Substring(0, 0) == ("A"))
                {
                    a.Add(rijec[u]);
                }
                else if (rijec[u].Substring(0, 1) == ("i") || rijec[0].Substring(0, 0) == ("I"))
                {
                    i.Add(rijec[u]);
                }
                else
                {
                    o.Add(rijec[u]);
                }
            }

            Console.WriteLine("Rijeći na a: " + a.Count + " , rijeći na i: " + i.Count + " , a ostalih rijeći je: " + o.Count);

        }
    }
}
