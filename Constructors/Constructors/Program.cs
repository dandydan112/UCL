namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car peen = new Car("Toyota", "Supra", 2022, "Black");
            Car penis = new Car("Ford", "Mustang", 2020, "White");

            Console.WriteLine(peen);

            peen.Drive();
            penis.Drive();


            Console.ReadLine();
        }

        

    }
}
