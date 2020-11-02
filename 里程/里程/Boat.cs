using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里程
{
    class Boat:Transport
    {
        private int bans = 0;
        public Boat(string Bm, string Bf)
        {
            TransMile = Convert.ToInt32(Bm);
            TranFuel = Convert.ToInt32(Bf);
        }
        public override string Cal()
        {
            bans = TransMile * TranFuel * 2;
            return bans + "";
        }
    }
}
