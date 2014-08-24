using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class MakeIce:IMakeIce
    {
        void IMakeIce.MakeIce()
        {
            Console.WriteLine("Ice done");
        }
    }
}
