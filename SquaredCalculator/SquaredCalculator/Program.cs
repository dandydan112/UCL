namespace SquaredCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int squaredLenght;
            int squaredWidth;

            Console.WriteLine();
            Console.Write("Type your lenght in cm: ");
            squaredLenght = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Type your width in cm: ");
            squaredWidth = int.Parse(Console.ReadLine());
            Console.WriteLine();

           int result = squaredLenght * squaredWidth;

            Console.WriteLine("Your result is " + result + " cm2");

            Console.ReadLine();



        }
    }
}