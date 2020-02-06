using System;

namespace strukturirano_upravljanje_exceptionima
{
    class Program
    {
        static void Main(string[] args)
        {
            string unos = "";
            try
            {
                Console.WriteLine("Unesi broj");
                unos = Console.ReadLine();
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Broj je {0}", a);
            }           
            catch (Exception ex1)
            {
                Console.WriteLine("Generička greška: \n unio si {0} \n" , unos, ex1.Message );
            }
            finally
            {
                Console.WriteLine("Ovo je vaše riješenje koje se odradilo bez obzira na uspješnost izvršenja programa");
            }




            







        }
    }
}
