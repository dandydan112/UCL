using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposableDelegates2
{
    // using reference parameters enables results to be passed 
    // along from one delegate to the next
    public delegate void MyDelegate(int arg1, ref int arg2);

    class Program
    {

        static void Main(string[] args)
        {
            int a = 10, b = 10;
            MyDelegate f1 = func1;
            MyDelegate f2 = func2;
            MyDelegate combined = f1 + f2;

            Console.WriteLine("The value of b is: {0}", b);
            combined(a, ref b);
            Console.WriteLine("The value of b is: {0}", b);

            Console.WriteLine("\nPress Enter Key to Continue...");
            Console.ReadLine();
        }
    }
}
