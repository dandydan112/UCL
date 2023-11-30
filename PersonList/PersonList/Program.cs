namespace PersonList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            bool run = true;

            do
            {
                Console.Write("Skriv Navn: ");
                string nameInput = Console.ReadLine();

                Console.Write("Skriv alder: ");
                int ageInput = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Person person = new Person(nameInput, ageInput);

                persons.Add(person);

                Console.WriteLine("Her er person arrayet");
                foreach (Person item in persons)
                {
                    Console.WriteLine(item.Name + " " + item.Age);
                }

                Console.WriteLine("");
                Console.WriteLine("Fortsæt?");
                string input = Console.ReadLine();

                if (input != "y")
                {
                    run = false;
                }
                Console.Clear();

            } while (run);

            Console.WriteLine("Done");
        }
    }
}