namespace AverageAgeGroup17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aldera = 23;
            int alderb = 38;
            int alderc = 23;
            int alderd = 20;
            int aldere = 25;
            int alderf = 19;

            double svar = (aldera + alderb + alderc + alderd + aldere + alderf) / 6;

            Console.WriteLine(String.Concat(aldera, "\n", alderb, "\n", alderc, "\n", alderd, "\n", aldere, "\n", alderf, "\n", svar));

            Console.ReadLine();
        }
    }
}