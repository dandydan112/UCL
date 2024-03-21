using System;
using System.Diagnostics;
using System.Threading;

namespace Process01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            string programName = "Process01"; // skal hedde det same som 
                                              // konsolapplikationen

            if (args.Length == 0)
            {
                Console.Write("Indtast antal processer, der skal startes : ");
                int antal = int.Parse(Console.ReadLine());
                for (int i = 0; i < antal; i++)
                {
                    Console.WriteLine($"Starter proces {i}");
                    Process process = new Process();
                    process.StartInfo.FileName = programName;
                    process.StartInfo.Arguments = "\"" + programName + $", version {i}" + "\"";
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    process.Start();
                }
            }
            else
            {
                int current = 0;
                const int number = 5000;
                const int sleeptime = 5;
                while (running)
                {
                    current++;
                    Console.WriteLine(args[0] + $", counting to {number}....: " + current);
                    Thread.Sleep(sleeptime);
                    running = (current < number);
                }
            }
        }
    }
}
