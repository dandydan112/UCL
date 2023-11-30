using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    internal class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }

        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }

        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
            
        }

        public Pizza(String bread)
        {
            this.bread = bread;
        }

        public void Order()
        {
            Console.WriteLine("You ordered the " + bread + " " + sauce + " " + cheese + " " + topping);
        }
    }
}
