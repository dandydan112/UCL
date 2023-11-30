namespace PropertiesAutoImpl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.FirstName = "Dan";
            p.LastName = "Nguyen";
            p.Age = 19;

            Console.WriteLine(p);

            Console.ReadLine();

           
        }
    }
}