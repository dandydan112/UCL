using Pr31_OberserverPattern_Academy.ConcreteObservers;
using Pr31_OberserverPattern_Academy.ConcreteSubjects;

namespace Pr31_OberserverPattern_Academy.ConcreteSubjects
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Academy p = new Academy("UCL", "Seebladsgade");

            Student s1 = new Student(p, "Jens");

            Student s2 = new Student(p, "Niels");

            Student s3 = new Student(p, "Susan");

            p.MessageChanged+=s1.Update;

            p.MessageChanged += s2.Update;
            p.MessageChanged = null;

            p.MessageChanged += s3.Update;

            p.Message = "Så er der julefrokost!";

            p.MessageChanged -= s2.Update;

            p.Message = "Så er der fredagsbar!";

        }
    }
}