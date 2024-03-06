using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public delegate double BonusProvider(double amount);
    public class Bonuses
    {
        public static double TenPercent(double amount)
        {
            return amount *0.1;
        }

        public static double FlatTwoIfAmountMoreThanFive(double amount)
        {
            if(amount > 5)
            {
                return 2.0;
            }
            else
            {
                return 0.0;
            }

            // you could also use: return amount > 5.0 ? 2.0 : 0.0;
        }
    }
}
