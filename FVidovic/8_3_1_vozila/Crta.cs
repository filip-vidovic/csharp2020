using System;

namespace _8_3_1_vozila
{
    internal class Crta
    {
        private Tocka tocka1;
        private Tocka tocka2;

        public Crta(Tocka Tocka1, Tocka Tocka2)
        {
            tocka1 = Tocka1;
            tocka2 = Tocka2;
        }

        public double Duljina
        {
            get=> Math.Sqrt(Math.Pow(tocka1.X - tocka2.X, 2) + (Math.Pow(tocka1.Y - tocka2.Y, 2)));
        }
    }
}