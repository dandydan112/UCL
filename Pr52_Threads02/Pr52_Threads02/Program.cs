using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Pr52_Threads02
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.run();
        }
        public void run()
        {
            Console.WriteLine("Start");

            Buffer buffer = new Buffer(50);

            Producer producer1 = new Producer("Opel", buffer);
            Producer producer2 = new Producer("Audi", buffer);
            Consumer consumer1 = new Consumer("Forhandler 1", buffer);
            Consumer consumer2 = new Consumer("Forhandler 2", buffer);
            Consumer consumer3 = new Consumer("Forhandler 3", buffer);

            Thread tp1 = new Thread(producer1.Run);
            Thread tp2 = new Thread(producer2.Run);
            Thread tc1 = new Thread(consumer1.Run);
            Thread tc2 = new Thread(consumer2.Run);
            Thread tc3 = new Thread(consumer3.Run);

            System.Console.WriteLine("\nEnter for consumer 1 start");
            System.Console.ReadLine();
            tc1.Start();

            System.Console.WriteLine("\nEnter for producer 1 start");
            System.Console.ReadLine();
            tp1.Start();

            System.Console.WriteLine("\nEnter for consumer 2 start");
            System.Console.ReadLine();
            tc2.Start();

            System.Console.WriteLine("\nEnter for producer 2 start");
            System.Console.ReadLine();
            tp2.Start();

            System.Console.WriteLine("\nEnter for consumer 3 start");
            System.Console.ReadLine();
            tc3.Start();

            System.Console.WriteLine("\nStop tråde");
            System.Console.ReadLine();

            producer1.SignalStop();
            producer2.SignalStop();
            consumer1.SignalStop();
            consumer2.SignalStop();
            consumer3.SignalStop();

            tp1.Join();
            tp2.Join();
            tc1.Join();
            tc2.Join();
            tc3.Join();
            System.Console.WriteLine("\nEnter for Exit");
            System.Console.ReadLine();
            System.Console.WriteLine("Exit");
        }
    }
}

