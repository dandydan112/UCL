namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pik = "123456";
            string pik2;

            pik2 = pik.Shift(1);

            Console.WriteLine(pik2);

            pik2 = pik.Shift(-1);

            Console.WriteLine(pik2);


            Console.WriteLine("Tid til at teste datetimes");

            DateTime birth = new DateTime(2003, 3, 1);
            int age = birth.Age(new DateTime(2023, 3, 5));

            Console.WriteLine(age);

            Console.ReadLine();




        }
    }
}