namespace Inheretance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the base class
            Animal genericAnimal = new Animal("Generic", 5);
            Console.WriteLine($"Generic animal: {genericAnimal.Name}, Age: {genericAnimal.Age}");
            genericAnimal.Speak();

            // Creating an instance of the derived class
            Dog myDog = new Dog("Buddy", 3);
            Console.WriteLine($"My dog: {myDog.Name}, Age: {myDog.Age}");
            myDog.Speak();

            Console.ReadLine();
        }
    }
}