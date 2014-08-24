using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Strategy pattern is used to encapsulate algoritmns in objects, so the implementation
             * is not coupled to the main object. With that, your code will be more flexible. 
             */
            string data = "Data to be storaged";

            IDBSource source;
            source = new MYSqlSource();
            Console.WriteLine(source.Save(data));

            source = new SQLServerSource();
            Console.WriteLine(source.Save(data));

            source = new JSONSource();
            Console.WriteLine(source.Save(data));

            /* You can also make better use of Inheritance. If you need that some of your inherited implements a method
             * that the others don't, you can use a interface for this method in the super class, make another class
             * that implements that method and in the inherited class create a instance of the implemented class that it needs.
             */

            // This class sets an instance of MakeIce in its constructor, so it's going to make ice.
            var fridgeWithFreezer = new FridgeWithFreezer();
            fridgeWithFreezer.MakeIce();

            // This class does note set an instance of MakeIce in its constructor, so it isn't going to make ice.
            var fridgeWithoutFreezer = new FridgeWithoutFreezer();
            fridgeWithoutFreezer.MakeIce();
        }
    }
}
