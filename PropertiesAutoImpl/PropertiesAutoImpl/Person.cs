using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAutoImpl
{
    public class Person
    {
        private string fullName;

        public string FullName
        {
            get { return fullName; }
        }

        private string firstName;

        public string FirstName
        {
            set 
            { 
                firstName = value; 
                fullName = firstName + " " + lastName;
            }
        }

        private string lastName;

        public string LastName
        {
            set 
            { 
                lastName = value;
                fullName = firstName + " " + lastName;
            }
        }


        public int Age { get; set; }

        public override string ToString()
        {
            return FullName + ": " + Age;
        }

    }
}
