using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDelegates
{
    // define a delegate 
    public delegate void myEventHandler(string value);

    class MyClass
    {
        private string theVal;
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
            MyClass obj = new MyClass();


            string str;
            do {
                str = Console.ReadLine();
                if (!str.Equals("exit")) {
                    obj.Val = str;
                }
            } while (!str.Equals("exit"));

            Console.WriteLine("Goodbye!");
        }
    }
}
