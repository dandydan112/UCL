namespace Teknologi_IsPrime_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Skriv dit tal");
                Console.WriteLine(IsPrime(int.Parse(Console.ReadLine())));
            }

        }
        public static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static List<int> GetPrimeFactors(uint number)
        {
            var primeFactors = new List<int>();

            // Divide by 2 until the number is odd
            while (number % 2 == 0)
            {
                primeFactors.Add(2);
                number /= 2;
            }

            // Check for odd factors from 3 upwards
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                while (number % i == 0)
                {
                    primeFactors.Add(i);
                    number /= i;
                }
            }

            // If the remaining number is a prime number greater than 2
            if (number > 2)
            {
                primeFactors.Add((int)number);
            }

            return primeFactors;
        }
    }
}
