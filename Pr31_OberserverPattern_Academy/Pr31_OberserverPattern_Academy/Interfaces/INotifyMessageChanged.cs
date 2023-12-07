using Pr31_OberserverPattern_Academy.ConcreteSubjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pr31_OberserverPattern_Academy.ConcreteSubjects;

namespace Pr31_OberserverPattern_Academy.Interfaces
{
    public interface INotifyMessageChanged
    {
        public event EventHandler MessageChanged;
    }
}
