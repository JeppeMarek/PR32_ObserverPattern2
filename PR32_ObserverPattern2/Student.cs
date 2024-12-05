using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR32_ObserverPattern2.Interfaces;

namespace PR32_ObserverPattern2
{
    public class Student : Person, IObserver
    {
        // Field
        //private Academy academy;
        // Property
        public string Message { get; set; }
        // Constructor - base(name) calls the constructor from Organization and sets its Name property, to the argument in Student. 
        public Student(string name) : base(name)
        {

        }
        // Method
        public void Update(Object sender, EventArgs e)
        {
            if (sender is Academy academy)
            {
                Console.WriteLine($"Studerende {Name} modtag beskeden \"{academy.Message}\" fra {academy.Name}");
            }
        }
    }
}
