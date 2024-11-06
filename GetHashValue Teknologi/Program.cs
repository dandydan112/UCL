namespace GetHashValue_Teknologi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv dit password som skal hashes");
            string pik = Console.ReadLine();
            GetHashValue(pik);
            Console.WriteLine("Dit hashede password er: " + GetHashValue(pik));
            Console.WriteLine("Vil du prøve igen? (ja/nej)");
            string svar = Console.ReadLine();
            if (svar == "ja")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Programmet lukker");
            }   

        }
        public static int GetHashValue(string input)
        {
            int hash = 0;
            foreach (char c in input)
            {
                hash += c;
            }
            while (hash >= 100)
            {
                hash = hash -100;
            }
            return hash;
        }


    }
}
