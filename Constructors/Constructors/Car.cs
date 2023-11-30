using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Car
    {
        String make;
        String model;
        int year;
        String color;

        

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " +  model);
        }

        public override string ToString()
        {
            return "This is a " + make + " " + model;
        }

    }
}
