using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    
    public class Order
    {
        public List<Product> products = new List<Product>();
        public BonusProvider Bonus;
        public void AddProduct(Product p)
        {
            products.Add(p);

        }

        public double GetValueOfProducts()
        {
            double totalValue = 0;

            foreach (Product p in products)
            { 
                totalValue += p.Value;
            }
            return totalValue;

        }




        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
            

        }

        public double GetBonus(Func <double,double> bonus)
        {
            return bonus(GetValueOfProducts());
        }

        public double GetTotalPrice()
        {
           return GetValueOfProducts() - GetBonus();
        }

        public double GetTotalPrice(Func<double,double> bonus)
        {
            return GetValueOfProducts() - bonus(GetValueOfProducts());
        }



    }
}
