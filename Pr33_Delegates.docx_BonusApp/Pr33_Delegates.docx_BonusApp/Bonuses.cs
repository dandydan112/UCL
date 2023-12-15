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



        public static BonusProvider bp3 = arg =>
        {
            double result;

            result = arg / 10;

            return result;
        };

        public static BonusProvider bp4 = arg =>
        {
            if (arg > 5)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        };





        //public static BonusProvider bp = delegate (double arg)
        //{
        //    double result;

        //    result = arg / 10;

        //    return result;
        //};

        //public static BonusProvider bp2 = delegate (double arg)
        //{
        //if (arg > 5)
        //{
        //    return 2;
        //}
        //else
        //{
        //    return 0;
        //}
        //};

        public static Func<double, double> bp5 = (arg) =>
        {
            double result;

            result = arg / 10;

            return result;
        };

        public static Func<double, double> bp6 = (arg) =>
        {
            if (arg > 5)
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
        //    double result;

        //    result = amount / 10;

        //    return result;
        //}



        //public static double FlatTwoIfAmountMoreThanFive(double amount)
        //{
        //    if (amount > 5)
        //    {
        //        return 2;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}


    }
}
