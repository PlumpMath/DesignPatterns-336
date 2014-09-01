using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingletonLazyLoad
    {
        private static SingletonLazyLoad instance;
        private SingletonLazyLoad() { }

        public static SingletonLazyLoad getInstance()
        {
            if (instance == null)
            {
                instance = new SingletonLazyLoad();
            }
            return instance;
        }

        public string getDescription()
        {
            return "Unique instance.";
        }

    }
}
