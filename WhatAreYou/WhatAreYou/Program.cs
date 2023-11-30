namespace WhatAreYou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age? ");

            string inputAge = Console.ReadLine();
            int Age = int.Parse(inputAge);

            if (Age <= 12)

            {
                Console.WriteLine("You're a child.");
            }

            else if (Age >= 13 && Age <= 19)
            {
                Console.WriteLine("You're a teenager.");
            }


            else if (Age >= 20 && Age <= 25)
            {
                Console.WriteLine("Du er en studerende.");
            }

            else if (Age >= 26 && Age <= 67)
            {
                Console.WriteLine("Du er i arbejde.");
            }

            else
            {
                Console.WriteLine("Du er en pensionist.");
            }

            Console.ReadKey();
        }
    }
}