using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_KolokwiumB1
{
    interface IDruzyna
    {
        void UstawNapastnika(int p1, string p2, string p3, int p4);
        void UstawObronce(int p5, string p6, string p7, int p8);
        void UstawNazwe(string p9);
        bool CzyOK();
    }
}
