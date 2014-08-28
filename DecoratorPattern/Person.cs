using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Person : Human
    {
        public override string Walk()
        {
            return "Walking";
        }
    }
}
