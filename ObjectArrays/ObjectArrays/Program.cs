namespace ObjectArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] pikarray = { "pik" + 123 + "pik", "pik" };


            foreach (object obj in pikarray)
            {
                Console.WriteLine(obj);
            }


            Console.ReadLine();
        }
    }
}