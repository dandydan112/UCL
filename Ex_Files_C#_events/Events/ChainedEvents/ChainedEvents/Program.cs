using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedEvents
{
    // define the delegate for the event handler
    public delegate void myEventHandler(string value);

    class MyClass
    {
        private string theVal;
        // declare the event handler
        public event myEventHandler valueChanged;

        public string Val
        {
            set
            {
                this.theVal = value;
                // when the value changes, fire the event
                this.valueChanged(theVal);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // create the test class
            MyClass obj = new MyClass();


            string str;
            do {
                Console.WriteLine("Enter a value: ");
                str = Console.ReadLine();
                if (!str.Equals("exit")) {
                    obj.Val = str;
                }
            } while (!str.Equals("exit"));
            Console.WriteLine("Goodbye!");
        }

        static void changeListener1(string value)
        {
            Console.WriteLine("The value changed to {0}", value);
        }
        static void changeListener2(string value)
        {
            Console.WriteLine("I also listen to the event, and got {0}", value);
        }
    }
}
