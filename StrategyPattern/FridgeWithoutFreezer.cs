using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class FridgeWithoutFreezer : Fridge
    {

        public override void TurnON()
        {
            Console.WriteLine("Turned on");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Turned off");
        }
    }
}
