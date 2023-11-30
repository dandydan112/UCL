namespace Lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            bool run = true;
            

           

            do
            {

                Console.Clear();
                Console.WriteLine("Velkommen til lommeregner");
                Console.WriteLine("Skriv dit første tal: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Skriv dit andet tal: ");
                int y = int.Parse(Console.ReadLine());
                Console.Write("Vil du Add(1), Subtract(2) Multiply(3) eller Divide(4)? ");
                int userinput = int.Parse(Console.ReadLine());



                switch (userinput)
                {
                    case 1:
                        Console.WriteLine(calculator.Add(x, y));
                        break;

                    case 2:
                        Console.WriteLine(calculator.Subtract(x, y));
                        break;

                    case 3:
                        Console.WriteLine(calculator.Multiply(x, y));
                        break;

                    case 4:
                        Console.WriteLine(calculator.Divide(x, y));
                        break;

                    default:
                        Console.WriteLine("Skriv noget rigtigt ");
                        break;
                }

                Console.WriteLine("vil du bruge lommeregneren igen? Y/N");

                string pik = Console.ReadLine();

                string input = pik.ToUpper();

                if (input != "Y")
                {
                    run = false;
                }
                

            } while (run);
            
            
            Console.ReadLine();
        }
    }
}