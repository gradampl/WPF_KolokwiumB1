using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_KolokwiumB1
{
    class Druzyna:IDruzyna
    {
        string nazwa;
        Pilkarz[,] druzyna = new Pilkarz[2, 4];

        public void UstawNapastnika(int p1, string imie,string nazwisko,int numerNaKoszulce)
        {
            try
            {
                druzyna[0, p1] = new Napastnik(imie, nazwisko, numerNaKoszulce);
            }
            catch(IndexOutOfRangeException e)
            {
                e.Message.ToString();
            }
        }

        public void UstawObronce(int p1, string imie, string nazwisko, int numerNaKoszulce)
        {
            try
            {
                druzyna[1, p1] = new Obronca(imie, nazwisko, numerNaKoszulce);
            }
            catch (IndexOutOfRangeException e)
            {
                e.Message.ToString();
            }
        }

        public bool CzyOK()
        {
            foreach (var el in druzyna)
            {
                if (el == null)
                    return false;
            }
            return true;
        }

        public void UstawNazwe(string nazwa)
        {
            this.nazwa = nazwa;
        }

        public override string ToString()
        {
            string napis = "";
            for (int i = 0; i < druzyna.GetLength(0);i++ )
            {
                for (int j = 0; j < druzyna.GetLength(1);j++ )
                {
                    if (druzyna[i,j]!= null)
                    {
                        napis += String.Format("[{0},{1}] {2}", i, j, druzyna[i, j].ToString()) + Environment.NewLine;
                    }

                }
            }
            
            return napis;
        }
    }
}
