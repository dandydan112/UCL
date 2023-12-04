using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr33_Delegates.docx_BonusApp
{
    public delegate double BonusProvider(double amount);

    public class Bonuses
    {
        public static double TenPercent(double amount)
        {
            double result;

            result = amount / 10;

            return result;
        }

        

        public static double FlatTwoIfAmountMoreThanFive(double amount)
        {
            if (amount > 5)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }


    }
}
