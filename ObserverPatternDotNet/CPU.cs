using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDotNet
{
    class CPU : IObservable<int>
    {
        List<IObserver<int>> observers;
        public CPU()
        {
            observers = new List<IObserver<int>>();
        }
        public IDisposable Subscribe(IObserver<int> observer)
        {
            this.observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        public void ChangeTemperature(Nullable<int> temperature)
        {
            foreach (var observer in observers)
            {
                if (!temperature.HasValue)
                    observer.OnError(new Exception("Temperature not informed."));
                else
                    observer.OnNext(temperature.Value);
            }
            Console.WriteLine("-------------------------");
        }

        public void EndTransmission()
        {
            foreach (var observer in observers.ToArray())
                if (observers.Contains(observer))
                    observer.OnCompleted();

            observers.Clear();
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<int>> _observers;
            private IObserver<int> _observer;

            public Unsubscriber(List<IObserver<int>> observers, IObserver<int> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

    }

}
