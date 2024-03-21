namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new Person object
            Person person = new Person("John", 30);

            // Accessing private fields indirectly using public methods
            Console.WriteLine($"Name: {person.GetName()}, Age: {person.GetAge()}");

            // Modifying private fields indirectly using public methods
            person.SetName("Alice");
            person.SetAge(25);

            // Accessing modified private fields
            Console.WriteLine($"Name: {person.GetName()}, Age: {person.GetAge()}");

            Console.ReadLine();
        }
    }
}