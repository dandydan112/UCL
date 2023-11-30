namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                PlayGame();

                Console.Write("Do you want to play again? (yes/no): ");
                string playAgainInput = Console.ReadLine().ToLower();

                if (playAgainInput != "yes")
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing!");
        }

        static void PlayGame()
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 11);

            Console.WriteLine("Guess the secret number between 1 and 10:");

            int userGuess;
            bool validInput = int.TryParse(Console.ReadLine(), out userGuess);

            if (!validInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            if (userGuess == secretNumber)
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
            }
            else
            {
                Console.WriteLine($"Sorry, the secret number was {secretNumber}. Try again!");
            }
        }
    }
}