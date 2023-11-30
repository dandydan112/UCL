using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            if (age >= 0)
            {
                this.age = age;
            }
            else
            {
                this.age = -1;
            }


        }
        public int GetAge()
        {
            return age;
        }
        

        public string PikkeTitel()
        {
            string result;

            result = name + ": " + age + " år gammel.";

            return result;
        }
    }
}
