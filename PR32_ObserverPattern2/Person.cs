using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR32_ObserverPattern2
{
    public abstract class Person
    {
        // Properties
        public string Name { get; }
        // Constructor
        public Person(string name)
        {
            Name = name;
        }

    }
}
