using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr32_ObserverPattern
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject subject { get; set; }

        public int State { get; set; } = 0;

        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        public override void Update()
        {
            State = subject.State;
        }

    }
}
