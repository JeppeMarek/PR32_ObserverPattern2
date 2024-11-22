using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR32_ObserverPattern2
{
    public class Academy : Organization, ISubject
    {
        // Fields
        private List<IObserver> observers = new List<IObserver>();
        private string _message;
        // Property
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                Notify();
            }
        }
        // Constructor
        public Academy(string name, string address) : base(name)
        {
            Address = address;
        }
        // Methods
        public void Attach(IObserver o)
        {
            observers.Add(o);
        }

        public void Detach(IObserver o)
        {
            observers.Remove(o);
        }

        public void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update();
            }
        }
    }
}
