using System.Security.Cryptography.X509Certificates;

namespace SockMerchant
{
    public class Program
    {
        static void Main(string[] args)
        {




        }

        public static int SockMerchant(int[] arr)
        {
            int antal = 0;
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    antal++;
                    i++;
                }


            }
            return antal;

        }

        public static int CandleBlower(int[] arr)
        {
            int antal = 0;
            Array.Sort(arr);
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[0] == arr[i])
                {
                    antal++;

                }
                


            }
            return antal;

        }


    }
}