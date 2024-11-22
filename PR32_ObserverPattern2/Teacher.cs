using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR32_ObserverPattern2
{
    public class Teacher : Person
    {
        public string JobTitle { get; set; }
        public Teacher(string name) : base(name)
        {
        }
    }
}
