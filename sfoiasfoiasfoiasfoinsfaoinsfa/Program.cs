using System;
namespace sfoiasfoiasfoiasfoinsfaoinsfa
{
    class Program
    {
        private const int MAX_HASH_VALUE = 99;

        private const int HASH_VALUE_LENGTH = 2;

        static void Main(string[] args)
        {
            Program prog = new Program();

            prog.Run();
        }

        private void Run()

        {

            bool running = true;

            Console.WriteLine("Enter a password and get the hashed value.");

            while (running)

            {

                Console.Write("Enter password ('q' to end) : ");

                string answer = Console.ReadLine();

                if (answer.Equals("q"))

                {

                    running = false;

                    Console.WriteLine("Bye");

                }

                else

                {

                    Console.WriteLine(PadZero(GetHashValue(answer), HASH_VALUE_LENGTH));

                }

            }

        }

        public string PadZero(int value, int length)

        {

            string result = value.ToString();

            for (int idx = 0; result.Length < HASH_VALUE_LENGTH; idx++)

            {

                result = "0" + result;

            }

            return result;

        }

        public int GetHashValue(string password)

        {

            int result = 0;

            for (int i = 0; i < password.Length; i++)

            {

                result += Convert.ToInt16(password[i]);

            }

            return result % (MAX_HASH_VALUE + 1);

        }

    }

}
