namespace MethodParameters
{
    internal class Program
    {


        static void MyMethod(string penis, int age)
        {
            Console.WriteLine(penis + " " + "Nguyen " + age);
        }
        static void MyMethod(string country = "Denmark")
        {
            Console.WriteLine(country);
        }


        static void Main(string[] args)
        {



            MyMethod("dan", 5);
            MyMethod("lasse", 100);

            Console.ReadLine();
        }
    }
}
