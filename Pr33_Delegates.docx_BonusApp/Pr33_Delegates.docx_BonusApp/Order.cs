using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Pr33_Delegates.docx_BonusApp
{

    public class Order
    {
        public BonusProvider Bonus { get; set; }

        private List<Product> products = new List<Product>();

        public void AddProduct(Product p)
        {
            products.Add(p);
        }

        public double GetValueOfProducts()
        {
            double result = 0;

            foreach (Product p in products)
            {
                result += p.Value;
            }
            return result;
        }

        public double GetBonus()
        {
            double result = Bonus(GetValueOfProducts());
            return result;
        }

        public double GetBonus(BonusProvider arg)
        {
            return arg(GetValueOfProducts());
        }

        

        


        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }

        
        public double GetTotalPrice(BonusProvider arg)
        {
            return arg(GetValueOfProducts()) - arg(GetBonus());
        }



    }
}
