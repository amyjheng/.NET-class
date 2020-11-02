using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里程
{
    class Car:Transport
    {
        private int cars = 0;
        public override string Cal()
        {
            cars = TransMile * TranFuel;
            return cars + "";
        }
        public Car(string cm, string cf)
        {

            TransMile = Convert.ToInt32(cm);
            TranFuel = Convert.ToInt32(cf);
        }
    }
}
