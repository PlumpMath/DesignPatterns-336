using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class SingletonThreadSafe
    {
        private static SingletonThreadSafe instance;
        private SingletonThreadSafe() { }
        
        public static SingletonThreadSafe getInstance()
        {
            lock (typeof(SingletonThreadSafe))
            {
                if (instance == null)
                {
                    instance = new SingletonThreadSafe();
                }
            }
            return instance;
        }

        public string getDescription()
        {
            return "Unique instance.";
        }

    }
}
