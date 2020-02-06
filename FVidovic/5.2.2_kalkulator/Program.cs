using System;


/**
 * kalkulator sa osnovnim operacijama + - * /
 * korisnik unosi 2 broja i operaciju
 * na ekranu se ispisuje rezultat i sve poruke 
 * */
namespace _5._2._2_kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi prvi broj");
            float br1=0;
            try
            {
                br1 = float.Parse(Console.ReadLine());
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception eex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                Console.WriteLine("Ne prepoznajem broj");

            }
            Console.WriteLine("Unesi drugi broj");
            float br2 = 0;
            try
            {
                br2 = float.Parse(Console.ReadLine());
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception eex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                Console.WriteLine("Ne prepoznajem broj");
                br2 = 0;
            }
            Console.WriteLine("Unesi operator: \n+ , -, * ili /");
            char op = char.Parse(Console.ReadLine());

           
                
                if (op == '+')
                {                    
                    Console.WriteLine("Riješenje je " + (br1 + br2));
                }
                else
                {
                    if (op == '-')
                    {
                        Console.WriteLine("Riješenje je " + (br1 - br2));
                    }
                    else
                    {
                        if (op == '*')

                        {
                            Console.WriteLine("Riješenje je " + (br1 * br2));
                        }

                        else
                        {
                            if (op == '/')
                            {
                                Console.WriteLine("Riješenje je " + (br1 / br2));
                            }
                            else

                            {
                                Console.WriteLine("Niste unjeli jedan od ponuđenih operatora");
                            }
                        }
                    }
                }
            }



           
            
                    }
                }


            
 
