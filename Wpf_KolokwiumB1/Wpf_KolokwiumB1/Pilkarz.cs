using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_KolokwiumB1
{
    abstract class Pilkarz
    {
        protected string imie;
        protected string nazwisko;
        protected int numerNaKoszulce;

        public override string ToString()
        {
            return "Imie i nazwisko: " + imie + " " + nazwisko + ", " + "Numer na koszulce: " + numerNaKoszulce;
        }
    }
}
