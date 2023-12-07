using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public class Academy : Organization, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        private string message;
        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                PropertyChanged(this, null);
            }
        }

        public Academy(string name, string address) : base(name)
        {
            this.Address = address;
        }


        //private List<IObserver> observers = new List<IObserver>();


        public void OnMessageChanged(object sender, EventArgs e)
        {
            PropertyChanged(this, null);

        }
    }
}
