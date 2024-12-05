using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PR32_ObserverPattern2.Interfaces;

namespace PR32_ObserverPattern2
{
   // public delegate void NotifyHandler();
    public class Academy : Organization, INotifyPropertyChanged
    {
        // Fields
        private string _message;

       // public event EventHandler MessageChanged;
        public event PropertyChangedEventHandler? PropertyChanged;
        // Property
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnMessageChanged(this,null);
            }
        }
        // Constructor
        public Academy(string name, string address) : base(name)
        {
            Address = address;
        }

        public void OnMessageChanged(Object sender, EventArgs e)
        {
            PropertyChanged.Invoke(this,null);
        }

       
    }
}
