using System;

namespace _8_3_1_vozila
{
    internal class MojStatic
    {
        internal static double zbroj(double broj1, double broj2)
        {
            return broj1 + broj2;
        }

        internal static double kub(double broj1)
        {
            return Math.Pow(broj1, 3);
        }

        internal static double udaljenostocaka(Tocka tocka1, Tocka tocka2)
        {
            return Math.Sqrt(Math.Pow(tocka1.X - tocka2.X, 2) + (Math.Pow(tocka1.Y - tocka2.Y, 2)));

        }
    }
}