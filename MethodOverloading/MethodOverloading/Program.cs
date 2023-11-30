namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Plus(int x, int y)
            {
                return x + y;
            }

            Console.WriteLine("Skriv x ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv y: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x + y);
            Console.ReadLine();

            static PlusMethodInt(int x, int y)


            {
                return x + y;
            }
            PlusMethodInt(5, 5);


        }
    }
}