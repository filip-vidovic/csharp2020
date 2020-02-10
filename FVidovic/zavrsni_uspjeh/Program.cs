using System;

namespace zavrsni_uspjeh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi broj predmeta");
            // todo unesi broj predmeta
            // za svaki predmet unesi ocjenu
            // za sve poz racuna prosjek
            // inace ispisuje uspjeh nedovoljan
            // za pogresno ispisi gresku i ponovi unos
            int broj_pred = int.Parse(Console.ReadLine());
            int suma = 0;
            int ulaz;
            for (int i = 0; i < broj_pred; i++)
            {
                Console.WriteLine("Unesi {0}. ocijenu:",(i+1));
                try
                {
                    ulaz = int.Parse(Console.ReadLine());                                     
    }
                catch (Exception ex)
                {
                    Console.WriteLine("neispravan unos!\n", ex.Message);
                    i--;
                    continue;
                }
                if (ulaz < 2)
                {
                    suma = 0;
                    break;
                }
                else
                    suma += ulaz;
            }
            if (suma == 0)
            {
                Console.WriteLine("Uspjeh je nedovoljan");
            }
            else
            {
                Console.WriteLine("Prosjek ocjena je {0:F2}",((float)suma / (float)broj_pred));

            }









        }


    }
}


