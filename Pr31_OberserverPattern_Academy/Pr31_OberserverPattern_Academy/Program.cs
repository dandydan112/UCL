using Pr31_OberserverPattern_Academy.ConcreteObservers;
using Pr31_OberserverPattern_Academy.ConcreteSubjects;

namespace Pr31_OberserverPattern_Academy.ConcreteSubjects
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Academy p = new Academy("UCL", "Seebladsgade");

            Student s1 = new Student("Jens");

            Student s2 = new Student("Niels");

            Student s3 = new Student("Susan");

            p.PropertyChanged += s1.Update;

            p.PropertyChanged += s2.Update;
            
            //p.MessageChanged = null;

            p.PropertyChanged += s3.Update;

            p.Message = "Så er der julefrokost!";

            p.PropertyChanged -= s2.Update;

            p.Message = "Så er der fredagsbar!";

        }
    }
}