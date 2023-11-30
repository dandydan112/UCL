namespace ArraysAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[10];
            bool run = true;
            int i = 0;

            do
            {
                Console.Write("Skriv Navn: ");
                string nameInput = Console.ReadLine();

                Console.Write("Skriv alder: ");
                int ageInput = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Person person = new Person();

                person.Name = nameInput;
                person.Age = ageInput;


                persons[i] = person;
                i++;

                Console.WriteLine("Her er person arrayet");
                foreach(Person item in persons)
                {
                    if(item == null)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.WriteLine(item.Name + " " + item.Age);
                    }
                }
                
                Console.WriteLine("");
                Console.WriteLine("Fortsæt? y/n");
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