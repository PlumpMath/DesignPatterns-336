using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    abstract class Fridge
    {
        public IMakeIce IceMaker;
        public abstract void TurnON();
        public abstract void TurnOff();

        public void MakeIce()
        { 
            if (IceMaker != null)
            {
                IceMaker.MakeIce();
            }
            else
            {
                Console.WriteLine("This fridge is not able to make ice");
            }
        }
    }
}
