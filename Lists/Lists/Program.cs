namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> list = new List<String>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");

            foreach (String item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            list.Remove("1");
            list.Remove("3");

            foreach (String item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(list[2]);

            Console.ReadLine();

        }
    }
}