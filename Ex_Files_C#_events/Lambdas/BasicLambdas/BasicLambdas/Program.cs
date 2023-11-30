using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLambdas
{
    // define a few delegate types
    public delegate int MyDelegate(int x);
    public delegate void MyDelegate2(int x, string prefix);
    public delegate bool ExprDelegate(int x);

    class Program
    {
        static void Main(string[] args)
        {

            // Keep the Command Line window open
            Console.WriteLine("\nPress Enter Key to Continue...");
            Console.ReadLine();
        }
    }
}
