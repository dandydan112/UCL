namespace Pr22ResourceManagement_08_11_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\..\TextFile1.txt";
            //StreamWriter writer = new StreamWriter(path);
            //writer.Close;


            //StreamReader reader = new StreamReader(path);

            try
            {
                writer.Write("Hello");
            }
            finally 
            { 
                writer.Close(); 
            }

            //using StreamWriter writer = new StreamWriter(path);


            //while (reader.EndOfStream == false)
            //{
            //    string line = reader.ReadLine();
            //    Console.WriteLine(line);
            //}
            //reader.Close();


            //Console.ReadLine();

        }
    }
}