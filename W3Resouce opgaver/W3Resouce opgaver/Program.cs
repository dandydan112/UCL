namespace W3Resouce_opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Hej Dan. du kan finde opgaverne som vil løse her: https://www.w3resource.com/csharp-exercises/basic/index.php
            //// Basic Opg 1

            ////Console.WriteLine("Hello");
            //Console.WriteLine("Dan");                   

            ////Basic Opg 2
            ////Console.WriteLine(2 + 2);


            ////Basic Opg 3
            ////Console.WriteLine(2 / 2);

            ////Basic Opg 4
            //Console.WriteLine(-1 + 4 * 6);
            //Console.WriteLine((35 + 5) % 7);
            //Console.WriteLine(14 + -4 * 6 / 11);
            //Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

            ////Basic Opg 5
            //Console.Write("Skriv første tal: ");
            //string firstnumber = Console.ReadLine();
            //Console.Write("\nSkriv dit andet tal: ");
            //string secondnumber = Console.ReadLine();
            //Console.WriteLine("\nDit første nummer er: " + secondnumber + "\nog dit andet nummer er: " + firstnumber);

            //Basic Opg 6
            Console.WriteLine("Skriv første tal: ");
            string one = Console.ReadLine();

            Console.WriteLine("Skriv andet tal: ");
            string two = Console.ReadLine();

            Console.WriteLine("Skriv tredje tal: ");
            string three = Console.ReadLine();

            int num1 = Convert.ToInt32(one);
            int num2 = Convert.ToInt32(two);
            int num3 = Convert.ToInt32(three);
            int answer = num1 * num2 * num3;
            string stringsvar = Convert.ToString(answer);

            Console.WriteLine(one + " * " + two + " * " + three + " = " + stringsvar);
            

















            Console.ReadKey();




        }
    }
}