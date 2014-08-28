using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Crutches : WalkDeviceDecorator
    {
        Human human;
        public Crutches(Human human)
        {
            this.human = human;
        }
        public override string Walk()
        {
            return human.Walk() + " with crutches ";
        }
    }
}
