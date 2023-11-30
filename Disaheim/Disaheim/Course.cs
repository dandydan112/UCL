using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
        public static double CourseHourValue { get; set; } = 875;
        public string Name { get; set; }

        public int DurationInMinutes { get; set; }

        public Course(string name)
        {
            this.Name = name;
        }

        public Course(string name, int durationInMinutes = 0) : this(name)
        {
            this.DurationInMinutes = durationInMinutes;
        }

        

        public double GetValue()
        {
            if (DurationInMinutes == 0)
            {
                CourseHourValue = 0;
                return CourseHourValue;
            }
            else if (DurationInMinutes % 60 == 0)
            {
                CourseHourValue = DurationInMinutes / 60 * 875;
                return CourseHourValue;
            }
            else
            {
                int rest = DurationInMinutes % 60;
                CourseHourValue = (DurationInMinutes - rest) / 60 * 875 + 875;
                return CourseHourValue;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {CourseHourValue}";
        }

    }
}
