using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_KolokwiumB1
{
    class Napastnik:Pilkarz
    {
        public Napastnik(string imie,string nazwisko,int numerNaKoszulce)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            if (!(numerNaKoszulce % 2 == 0))
            {
                throw new BlednyNumerException("Błędny numer!");
            }
            else
                this.numerNaKoszulce = numerNaKoszulce;
        }
        
        public override string ToString()
        {
            string napis = "Napastnik: ";
            napis += base.ToString();
            return napis;
        }
        
    }
}
