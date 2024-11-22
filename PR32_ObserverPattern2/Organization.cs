using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR32_ObserverPattern2
{
    public abstract class Organization
    {
        // Properties
        public string Name { get; }
        public string Address { get; set; }

        // Concstructor
        public Organization(string name)
        {
            Name = name;
        }
    }
}
