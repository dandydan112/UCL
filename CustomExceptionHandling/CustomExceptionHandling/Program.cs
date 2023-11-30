using System;
using TotallySafeLib;
using static TotallySafeLib.TotallySafe;

namespace CustomExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)

        {

            try
            {
                int posValue = TotallySafe.GetValueAtPosition(-2);

                Console.WriteLine(posValue);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Exception bliver kørt");
                Console.WriteLine(ex.Message);
            }
            catch (NegativeIndexOutOFRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("pik");
            }

            //try
            //{
            //    TotallySafe.Divider(0);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("pik");
            //}


            ////try
            ////{
            ////    TotallySafe.StringToInt("pik");
            ////}
            ////catch (FormatException ex)
            ////{
            ////    Console.WriteLine(ex.Message);
            ////}
            ////finally { Console.WriteLine("pik"); }


            Console.ReadLine();



        }
    }
}