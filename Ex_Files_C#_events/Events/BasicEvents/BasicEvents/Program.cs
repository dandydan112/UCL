using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicEvents
{
    // define the delegate for the event handler
    public delegate void myEventHandler(string value);


    class Program
    {
        static void Main(string[] args)
        {

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

    }
}
