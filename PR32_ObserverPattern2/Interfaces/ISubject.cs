using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR32_ObserverPattern2.Interfaces
{
    public interface ISubject
    {
        // Methods
        public void Attach(IObserver o);
        public void Detach(IObserver o);
        public void Notify();
    }
}
