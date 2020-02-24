using System;

namespace _8_1_svojstvametodedogadjaji
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Myclass mc1 = new Myclass();
            mc1.zbroj();
            Myclass2 mc2 = new Myclass2();
            mc2.zbroj("Test");
            Myclass3 mc3 = new Myclass3();
            mc3.zbroj("Seceond Test");
        }
    }

    class Myclass
    {
        public void zbroj()
        {
            Console.WriteLine("1.");
        }
    }

    class Myclass2
    {
        public void zbroj(string v1)
        {
            Console.WriteLine("2.");
        }
    }

    class Myclass3
    {
        public void zbroj(string v2)
        {
            Console.WriteLine("3.");
        }
    }

    

}
