using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class CPU : ISubject
    {
        List<IObserver> observers = new List<IObserver>();

        public string Product { get; set; }
        private int temperature;

        public int Temperature
        {
            get { return temperature; }
            set
            {
                if (temperature != value)
                {
                    temperature = value;
                    NotifyObservers();
                }
            }
        }

        public void AddObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var o in this.observers)
            {
                o.Update(this.temperature);
            }
            Console.WriteLine("----------------------------");
        }


    }

}
