namespace StreamWriterStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*StreamWriter writer;
            writer = new StreamWriter("test.txt");
            writer.WriteLine("Sut pikken");
            writer.Close();
            StreamReader reader;
            reader = new StreamReader("test.txt");
            string line = reader.ReadLine();
            Console.WriteLine(line);
            Console.ReadLine();*/


            string path = @"C:\Users\Dan\Documents/test.txt";
            StreamWriter writer;
            writer = new StreamWriter(path);
            for (int i = 0; i < 3; i++)
            {
                writer.WriteLine("hello world");
            }


            writer.Close();
            StreamReader reader = new StreamReader(path);
            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
            reader.Close();


            Console.ReadLine(); 
        }
    }
}