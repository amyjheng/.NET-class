using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里程
{
    public abstract class Transport
    {
        public int TransMile {get; set;}
        public int TranFuel { get; set; }
        public abstract string Cal();


    }
}
