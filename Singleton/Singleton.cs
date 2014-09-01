using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        private static Singleton instance = new Singleton();
        private Singleton() { }

        public static Singleton getInstance()
        {
            return instance;
        }

        public string getDescription()
        {
            return "Unique instance.";
        }
    }
}
