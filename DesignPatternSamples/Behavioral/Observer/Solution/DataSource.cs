using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Observer.Solution
{
    public class DataSource : ISubject
    {
        List<IObserver> observers = new List<IObserver>();
        private int value;

        public int Value { 
            get => value; 
            set {
                this.value = value;
                NotifyObservers();
            } 
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Notify();
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
