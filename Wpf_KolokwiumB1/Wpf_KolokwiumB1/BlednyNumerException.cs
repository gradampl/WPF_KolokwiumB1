using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_KolokwiumB1
{
    class BlednyNumerException:SystemException
    {
        
        public BlednyNumerException(string message)
            :base(message)
        {
           
        }
    }
}
