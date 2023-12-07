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
    internal class Student : Person, IObserver
    {
        //private Academy academy { get; set; }

        private string message;

        public string Message
        {
            get { return message; }
            set
            {
                message = value;

            }
        }



        public Student(string name) : base(name)
        {
        }

        public void Update(object sender, EventArgs e)
        {

            Message = (sender as Academy).Message;
            Console.WriteLine($"Studerende {Name} modtog nyheden '{Message}' fra Akademiet {(sender as Academy).Name}");

        }
    }
}
