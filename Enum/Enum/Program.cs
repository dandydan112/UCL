namespace Enum
{

    //enum Day
    //{
    //    MANDAG, TIRSDAG, ONSDAG, TORSDAG, FREDAG, LØRDAG, SØNDAG
    //}

    enum Gruppe
    {
        Asger,
        Dan,
        Fisker,
        Frederik,
        Martin,
        Victor
    }

    internal class Program
    {


        static void Main(string[] args)
        {
            //Day dag = Day.SØNDAG;

            //switch (dag)
            //{

            //    case Day.MANDAG:
            //        Console.WriteLine("Mandag");
            //        break;
            //    case Day.TIRSDAG:
            //        Console.WriteLine("Tirdag");
            //        break;
            //    case Day.ONSDAG:
            //        Console.WriteLine("Onsdag");
            //        break;
            //    case Day.TORSDAG:
            //        Console.WriteLine("Torsdag");
            //        break;
            //    case Day.FREDAG:
            //        Console.WriteLine("Fredag");
            //        break;
            //    case Day.LØRDAG:
            //        Console.WriteLine("Lørdag");
            //        break;
            //    case Day.SØNDAG:
            //        Console.WriteLine("Søndag");
            //        break;
            //}

            //Console.ReadLine();

            Gruppe person = Gruppe.Dan;

            switch (person)
            {
                case Gruppe.Asger:
                    Console.WriteLine("asger");
                    break;
                case Gruppe.Dan:
                    Console.WriteLine("dan");
                    break;
                case Gruppe.Fisker:
                    Console.WriteLine("fisker");
                    break;
                case Gruppe.Frederik:
                    Console.WriteLine("frederik");
                    break;
                case Gruppe.Martin:
                    Console.WriteLine("Martin");
                    break;
                case Gruppe.Victor:
                    Console.WriteLine("victor");
                    break;



            }


            Console.ReadLine();
        }
    }
}