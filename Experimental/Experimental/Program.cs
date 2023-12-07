using System.Diagnostics;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Experimental
{
    internal class Program
    {
        public delegate int MyDelegate(int a, int b);




        static void Main(string[] args)
        {
            Func<int, int, int> Addition = AddNumbers;
            int result = Addition(10, 20);
            Console.WriteLine($"Addition = {result}");
            Console.ReadLine();
        }

        private static int AddNumbers(int param1, int param2)
        {           
            return param1 + param2;
        }
    }
}