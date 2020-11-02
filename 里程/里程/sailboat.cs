using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里程
{
    class sailboat: Transport
    {
        private int sans = 0;
        public sailboat(string Tm, string Tf)
        {
            TransMile = Convert.ToInt32(Tm);
            TranFuel = Convert.ToInt32(Tf);
        }
        public override string Cal()
        {
            sans = TransMile * TranFuel * 3;
            return sans + "";
        }

    }
}
