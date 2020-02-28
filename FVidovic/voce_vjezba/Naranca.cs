using System;
using System.Collections.Generic;
using System.Text;

namespace voce_vjezba
{
    class Naranca:Voce
    {
        private double v;

        public Naranca(double v)
        {
            this.v = v;
        }

        public double Radijus
        {
            get => Radijus;
            set => Radijus = value;
        }
    }
}
