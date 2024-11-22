using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR32_ObserverPattern2
{
    public class Student : Person, IObserver
    {
        // Field
        private Academy academy;
        // Property
        public string Message { get; set; }
        // Constructor - base(name) calls the constructor from Organization and sets its Name property, to the argument in Student. 
        public Student(Academy academy, string name) : base(name)
        {
            this.academy = academy;
        }
        // Method
        public void Update()
        {
            Message = academy.Message;
            Console.WriteLine($"Studerende {Name} modtag beskeden \"{Message}\" fra {academy.Name}");
        }
    }
}
