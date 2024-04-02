using ADT;

namespace LinkedListConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList Trials ...");
            Console.WriteLine();

            // Instantiate a new list
            LinkedList list = new LinkedList();

            // Insert different types of elements in the list
            list.InsertAt(0, 123);
            list.InsertAt(1, "This is a LinkedList test");
            list.InsertAt(2, 456.75);
            list.InsertAt(3, new ClubMember { FirstName = "Donald", LastName = "Duck", Age = 90, Gender = Gender.Male, Id = 1 });

            // Write whole list to the console
            Console.WriteLine("** list.ToString() **");
            Console.WriteLine(list.ToString());
            Console.WriteLine();

            // Write element at index to console
            Console.WriteLine("** list.ItemAt() **");
            Console.WriteLine("Item at 2: " + list.ItemAt(2));
            Console.WriteLine("Item at 0: " + list.ItemAt(0));
            Console.WriteLine("Item at 3: " + list.ItemAt(3));
            Console.WriteLine();

            // Delete element at index
            Console.WriteLine("** list.DeleteAt(1) **");
            list.DeleteAt(1);
            Console.WriteLine("* Write list to console *");
            Console.WriteLine(list.ToString());
            Console.WriteLine();

            // Check invalid index
            Console.WriteLine("** Invalid index: list.ItemAt(-3) **");
            try
            {
                Console.WriteLine("Item at -3: " + list.ItemAt(-3));
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException: " + e.Message);
            }
            Console.WriteLine("** Invalid index: list.ItemAt(6) **");
            try
            {
                Console.WriteLine("Item at 6: " + list.ItemAt(6));
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException: " + e.Message);
            }
            Console.WriteLine();

            // Navigate data structure via Head
            Console.WriteLine("** Navigate Node-structure via Head and write to console **");
            Console.WriteLine("list.Head.Next.Next.Data: " + list.Head.Next.Next.Data);
            Console.WriteLine();

            Console.WriteLine("Trials Done");
            Console.ReadLine();
        }

    }
}
