namespace TheDecisionStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");

            Console.Write(Environment"Choose a door: 1, 2 or 3");

            String userValue = Console.ReadLine();

            if (userValue == "1")
            {
                string message = "you won a new car!";
                Console.WriteLine(message);
            }
        }
    }
}