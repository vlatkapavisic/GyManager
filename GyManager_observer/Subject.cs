using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GyManager_observer
{
    public abstract class Subject
    {
        List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver inObserver)
        {
            observers.Add(inObserver);
        }

        public void NotifyObservers()
        {
            foreach (IObserver obs in observers)
                obs.UpdateForm();
        }
    }
}
