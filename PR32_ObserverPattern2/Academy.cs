using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR32_ObserverPattern2
{
    public delegate void NotifyHandler();
    public class Academy : Organization
    {
        // Fields
        //private List<IObserver> students = new List<IObserver>();
        private string _message;

        // Property
        public NotifyHandler MessageChanged; 
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                MessageChanged.Invoke();
            }
        }
        // Constructor
        public Academy(string name, string address) : base(name)
        {
            Address = address;
        }

        public void Notify()
        {
            MessageChanged.Invoke();
        }
    }
}
