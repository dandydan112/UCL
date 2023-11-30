using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposableDelegates
{
    // declare the delegate type
    public delegate void MyDelegate(int arg1, int arg2);

    class Program
    {
        static void func1(int arg1, int arg2)
        {
            string result = (arg1 + arg2).ToString();
            Console.WriteLine("The number is: " + result);
        }
        static void func2(int arg1, int arg2)
        {
            string result = (arg1 * arg2).ToString();
            Console.WriteLine("The number is: " + result);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("\nPress Enter Key to Continue...");
            Console.ReadLine();
        }
    }
}
