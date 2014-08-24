using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class MobileMonitor : IObserver
    {
        public MobileMonitor(ISubject subject)
        {
            subject.AddObserver(this);
        }

        public void Update(int temperature)
        {
            Console.WriteLine("Mobile APP ::: Current CPU temperature: {0}", temperature);
        }
    }
}
