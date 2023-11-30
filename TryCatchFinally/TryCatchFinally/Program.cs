namespace TryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {



            try
            {
                // Code that may throw an exception
                int numerator = 10;
                int denominator = 0;
                int result = numerator / denominator; // This will throw a DivideByZeroException
            }
            catch (DivideByZeroException ex)
            {
                // Handle the exception
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            finally
            {
                // This block is optional and is used to execute code that must run whether an exception occurred or not
                Console.WriteLine("Finally block executed.");
            }

            // Rest of the program continues executing
            Console.WriteLine("Program continues executing after the try-catch block.");

            Console.ReadLine();



        }
    }
}