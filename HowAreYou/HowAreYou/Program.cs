namespace HowAreYou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! How are you doing today? (good/bad)");
            string userResponse = Console.ReadLine();

            if (userResponse.ToLower() == "good")
            {
                Console.WriteLine("That's great to hear!");
            }
            else if (userResponse.ToLower() == "bad")
            {
                Console.WriteLine("I'm sorry to hear that. I hope things get better!");
            }
            else
            {
                Console.WriteLine("I'm not sure I understand. Please enter 'good' or 'bad'.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}