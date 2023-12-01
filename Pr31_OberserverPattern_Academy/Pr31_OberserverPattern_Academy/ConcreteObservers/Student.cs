using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pr31_OberserverPattern_Academy.ConcreteSubjects;
using Pr31_OberserverPattern_Academy.Interfaces;
using Pr31_OberserverPattern_Academy.Observers;

namespace Pr31_OberserverPattern_Academy.ConcreteObservers
{
    internal class Student : Person
    {
        private Academy academy { get; set; }

        private string message;

        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                Console.WriteLine($"Studerende {Name} modtog nyheden '{Message}' fra Akademiet {academy.Name}");
                
            }
        }



        public Student(Academy academy, string name) : base(name)
        {
            this.academy = academy;
        }

        public void Update()
        {
            {
                Message = academy.Message;
            }
        }
    }
}
