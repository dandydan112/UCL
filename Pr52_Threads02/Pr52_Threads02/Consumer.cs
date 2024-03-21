using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;

namespace Pr52_Threads02
{
    class Consumer
    {
        private string name;
        private bool stop = false;
        private Buffer buffer;

        private Random randomGenerator = new Random((int)DateTime.Now.Ticks);

        public Consumer(string name, Buffer buffer)
        {
            this.name = name;
            this.buffer = buffer;
        }

        public void Run()
        {
            while (!stop)
            {
                System.Console.WriteLine(name + " Consume: ");
                Car car = buffer.Get();      //hent Car
                System.Console.WriteLine(name + " Received: " + car);
                Thread.Sleep(randomGenerator.Next(50, 1000));
            }
        }
        public void SignalStop()
        {
            stop = true;
        }
    }
}
