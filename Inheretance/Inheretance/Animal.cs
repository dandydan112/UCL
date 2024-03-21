using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretance
{
    // Base class
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }
}
