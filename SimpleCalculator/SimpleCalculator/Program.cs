namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, vil du gerne bruge en simpel lommeregner? Y/N");
           
            string response  = Console.ReadLine();

            if (response.ToUpper() == "Y")
            {
                Console.WriteLine("Fedt,");
            }
            Console.ReadLine();
        }
    }
}