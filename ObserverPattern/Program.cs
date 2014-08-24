using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var cpu = new CPU();

            var mobileMonitor = new MobileMonitor(cpu);
            var windowsMonitor = new WindowsMonitor(cpu);
            var webMonitor = new WebMonitor(cpu);

            cpu.Temperature = 10;
            Thread.Sleep(2000);
            cpu.Temperature = 5;
            Thread.Sleep(2000);
            cpu.Temperature = 1;
            Thread.Sleep(2000);
            cpu.Temperature = 7;
            Thread.Sleep(2000);
        }
    }
}
