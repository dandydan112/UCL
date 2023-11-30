using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr31_OberserverPattern_Academy.ConcreteObservers
{
    public class Person
    {
        public string Name { get; }

        public Person(string name)
        {
            this.Name = name;
        }

    }
}
