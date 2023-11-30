namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hej, Skriv dit navn: ");

            string name = Console.ReadLine();
            
            Console.Write("Skriv nu din alder: ");
            
            string age = Console.ReadLine();

            string result = string.Concat("Dit navn er ", name, " og din alder er ", age);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}