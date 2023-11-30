using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDelegates
{

    public delegate string MyDelegate(int arg1, int arg2);

    class Program
    {
        static void Main(string[] args)
        {
            // SNIPPET GOES HERE

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress Enter Key to Continue...");
            Console.ReadLine();
        }
    }
}
