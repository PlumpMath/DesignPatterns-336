using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var cpu = new CPU();
            var webMonitor = new WebMonitor();
            var winMonitor = new WindowsMonitor();
            var mobMonitor = new MobileMonitor();

            cpu.Subscribe(webMonitor);
            cpu.Subscribe(winMonitor);
            cpu.Subscribe(mobMonitor);

            cpu.ChangeTemperature(10);
            cpu.ChangeTemperature(20);
            cpu.ChangeTemperature(30);
            cpu.ChangeTemperature(null);
            cpu.ChangeTemperature(40);
            cpu.EndTransmission();
        }
    }
}
