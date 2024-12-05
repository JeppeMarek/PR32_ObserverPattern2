using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR32_ObserverPattern2.Interfaces
{
    public interface IObserver
    {
        // Method
        public void Update(Object sender, EventArgs e);
    }
}
