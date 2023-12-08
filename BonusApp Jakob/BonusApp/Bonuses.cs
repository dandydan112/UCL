using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Bonuses
    {
        public static BonusProvider ts = (ts) => 
        {
            double result; 
            result = ts / 10; 
            return result;
        };


        public static BonusProvider ts2 = (ts) =>
        {
            if(ts > 5)
            {
                return 2;
            }
            else
            {
                return 0;
            }
          
        };
        //public static double TenPercent(double amount)
        //{
        //    return amount * 0.1;
        //}

        //public static double FlatTwoIfAmountMoreThanFive(double amount) 
        //{
        //    if (amount > 5)
        //    {
        //        return 2.0;
        //    }
        //    else
        //    {
        //        return 0.0;
        //    }
        //}
    }
}
