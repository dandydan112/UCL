using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr52_Threads02
{
    class Car
    {
        private string name;
        private string serial;
        public string Name { get { return name; } }
        public string Serial { get { return serial; } }

        public Car(string name, string serial)
        {
            this.name = name;
            this.serial = serial;
        }

        public override string ToString()
        {
            return name + " " + serial;
        }
    }
}


