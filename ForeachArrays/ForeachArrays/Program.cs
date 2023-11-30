namespace ForeachArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] navne = { "dan", "asger", "fisker", "frederik", "martin", "victor" };

            foreach (string navn in navne)
            {
                Console.WriteLine(navn);
            }

            Console.WriteLine(navne);


            Console.ReadLine();
        }
    }
}