using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string Shift(this string input, int shift)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            int length = input.Length; // Gør livet lettere

            shift = (shift % length + length) % length; // Normaliser shift til et positivt tal inden for strengens længde

            return input.Substring(length - shift) + input.Substring(0, length - shift);
        }

        public static int Age(this DateTime fødsel, DateTime referenceDate)
        {
            if (fødsel > referenceDate)
            {
                return 0;
            }
            int age = referenceDate.Year - fødsel.Year;

            // Hvis fødselsdagen ikke er nået i det aktuelle år, træk et år fra
            if (fødsel > referenceDate.AddYears(-age))
            {
                age--;
            }

            return age;

            
        }
    }
}
    