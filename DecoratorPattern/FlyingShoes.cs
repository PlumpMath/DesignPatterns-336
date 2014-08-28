using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class FlyingShoes : Human
    {
        Human human;
        public FlyingShoes(Human human)
        {
            this.human = human;
        }

        public override string Walk()
        {
            return this.human.Walk() + " and flying";
        }
    }
}
