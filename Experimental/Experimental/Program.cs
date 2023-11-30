using System.Diagnostics;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Experimental
{
    internal class Program
    {

        


        static void Main(string[] args)
        {

            int a = 2; 
            int b = 3;

            static void PIK(int arg1,int arg2)
            {
                Console.WriteLine(arg1 + arg2);
            }
            PIK(a,b);
           
            Console.ReadLine();

        }
    }
}