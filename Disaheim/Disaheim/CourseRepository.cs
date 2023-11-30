using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class CourseRepository : Controller
    {
        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public Course? GetCourse(string name)
        {
            foreach (Course course in Courses)
            {
                if (name == course.Name)
                {
                    return course;
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            Utility utility = new Utility();

            double total = 0;
            foreach (Course course in Courses)
            {
                total += utility.GetValueOfCourse(course);
                //if (course.DurationInMinutes % 60 == 0)
                //{
                //    total += course.DurationInMinutes / 60 * 875;
                //}
                //else
                //{
                //    int rest = course.DurationInMinutes % 60;
                //    total += (course.DurationInMinutes - rest) / 60 * 875 + 875;
                
            }
            return total;
        }
        
    }
}
