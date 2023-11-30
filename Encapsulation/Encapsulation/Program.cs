namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person P;

            P = new Person("Dan");

            P.SetAge(30);



            P.SetAge(P.GetAge() + 1);

            string title = P.PikkeTitel();

            Console.WriteLine(title);

           

            Console.ReadLine();

        }
    }
}