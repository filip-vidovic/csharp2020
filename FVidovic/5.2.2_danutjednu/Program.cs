using System;

namespace _5._2._2_danutjednu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi dan u tjednu");
            Console.WriteLine("PON UTO SRI CET PET SUB NED");

            string dan = Console.ReadLine();

            switch (dan)
            {
                case "PON":
                case "UTO":
                case "SRI":
                case "CET":
                case "PET": Console.WriteLine("Radni dan"); break;

                case "NED":
                case "SUB": Console.WriteLine("Radni dan"); break;
                default: Console.WriteLine("Nepoznati dan?!");break;

            }
        }
    }
}
