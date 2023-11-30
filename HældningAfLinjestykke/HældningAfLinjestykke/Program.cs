namespace HældningAfLinjestykke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, vi vil gerne beregne hældningen på et linjestykke");
            Console.WriteLine("Skriv dine 4 punkter");
            Console.WriteLine("Skriv x koordinaten på punkt 1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv y koordinaten på punkt 1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv x koordinaten på punkt 2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv y koordinaten på punkt 2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            int hældning = (y2 - y1) / (x2 - x1);

            Console.WriteLine("Din hældning er: " + hældning + "!");

            Console.ReadLine();
           

            

        }
    }
}