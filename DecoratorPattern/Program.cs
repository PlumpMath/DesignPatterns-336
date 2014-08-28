using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            Console.WriteLine(person.Walk());

            var person2 = new Crutches(new Person());
            Console.WriteLine(person2.Walk());

            var person3 = new FlyingShoes(new Person());
            Console.WriteLine(person3.Walk());


        }
    }
}
