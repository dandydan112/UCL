using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallySafeLib
{
    public class TotallySafe
    {
        public static double Divider(int number)
        {
            return 7 / number;
        }
        public static int StringToInt(string stringToConvert)
        {
            return int.Parse(stringToConvert);
        }
        public static int GetValueAtPosition(int positionInArray)
        {
            if (positionInArray < 0)
            {
                throw new NegativeIndexOutOFRangeException();
            }

            int[] intArray = { 1, 2, 3, 4, 5 };
            return intArray[positionInArray];
        }


        public class NegativeIndexOutOFRangeException : Exception
        {
            public NegativeIndexOutOFRangeException()
            {
                
            }

            public NegativeIndexOutOFRangeException(string message)
                : base(message)
            {
            }

            public NegativeIndexOutOFRangeException(string message, Exception inner)
                : base(message, inner)
            {
            }
        }

        

    }
}