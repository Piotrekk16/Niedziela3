using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Samochod :Pojazd
    {
        private double srednieSpalanie;

        public Samochod() { }

        public Samochod(string marka, double srednieSpalanie)
            :base(marka)
        {
            this.srednieSpalanie = srednieSpalanie;
        }

        public double ObliczSpalanie(double dlTrasy)
        {
            return srednieSpalanie * dlTrasy / 100;

        }

        public double ObliczKosztPaliwa(double dlTrasy,double cenaPaliwa)
        {
            return ObliczSpalanie(dlTrasy) * cenaPaliwa;
        }

    }
}
