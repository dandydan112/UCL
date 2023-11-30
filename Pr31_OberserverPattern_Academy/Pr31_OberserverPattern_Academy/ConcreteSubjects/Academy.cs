using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pr31_OberserverPattern_Academy.Interfaces;
using Pr31_OberserverPattern_Academy.Observers;
using Pr31_OberserverPattern_Academy.Subjects;

namespace Pr31_OberserverPattern_Academy.ConcreteSubjects
{
    public class Academy : Organization, ISubject
    {


        private string message;
        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                Notify();
            }
        }
    


        public Academy(string name, string address) : base(name)
        {
            this.Address = address;
        }


        private List<IObserver> observers = new List<IObserver>();
        public void Attach(IObserver o)
        {
            observers.Add(o);
        }

        public void Detach(IObserver o)
        {
            observers.Remove(o);
        }

        public void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update();
            }
        }
    }
}
