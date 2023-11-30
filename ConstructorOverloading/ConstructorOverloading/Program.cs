namespace ConstructorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza("struffed crust", "red sauce", "mozzarella");


            pizza.Order();

            Console.ReadLine();
        }

        

        
    }
}