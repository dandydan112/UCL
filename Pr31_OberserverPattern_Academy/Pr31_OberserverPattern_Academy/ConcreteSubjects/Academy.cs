using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pr31_OberserverPattern_Academy.Interfaces;
using Pr31_OberserverPattern_Academy.Observers;
using Pr31_OberserverPattern_Academy.Subjects;

namespace Pr31_OberserverPattern_Academy.ConcreteSubjects
{
    public delegate void NotifyHandler();
    public class Academy : Organization
    {
        public NotifyHandler MessageChanged;
      





        private string message;
        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                MessageChanged();
            }
        }
    


        public Academy(string name, string address) : base(name)
        {
            this.Address = address;
        }


        //private List<IObserver> observers = new List<IObserver>();

        
        

        

        public void OnMessageChanged()
        {
            MessageChanged();
        }
    }
}
