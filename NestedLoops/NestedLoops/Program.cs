namespace NestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv antal lodrette rækker: ");
            int lodret = Convert.ToInt32(Console.ReadLine());
            Console.Write("skriv vandrette rækker: ");
            int vandret = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < lodret; i++)
            {
                for (int j = 0; j < vandret; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
           
            Console.ReadKey();
        }
    }
}