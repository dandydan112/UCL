using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;

namespace Pr52_Threads02
{
    class Buffer
    {
        private Queue<Car> bufferData;
        private int capacity;
        private object bufferLock = new object();

        public Buffer(int capacity)
        {
            this.capacity = capacity;
            bufferData = new Queue<Car>();
        }

        public void Put(Car car)
        {
            Monitor.Enter(bufferLock);
            try
            {
                while (IsFull())
                {
                    Monitor.Wait(bufferLock);
                }
                bufferData.Enqueue(car);
                Monitor.Pulse(bufferLock);
            }
            finally
            {
                Monitor.Exit(bufferLock);
            }
        }

        public Car Get()
        {
            Car car;
            Monitor.Enter(bufferLock);
            try
            {
                while (IsEmpty())
                {
                    Monitor.Wait(bufferLock);
                }
                car = bufferData.Dequeue();
                Monitor.Pulse(bufferLock);
            }
            finally
            {
                Monitor.Exit(bufferLock);
            }
            return car;
        }

        public bool IsEmpty()
        {
            return bufferData.Count == 0;
        }

        public bool IsFull()
        {
            return bufferData.Count == capacity;
        }
    }
}

