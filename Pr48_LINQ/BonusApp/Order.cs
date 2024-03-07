using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BonusApp
{
    public class Order
    {
        public BonusProvider Bonus { get; set; }
        private List<Product> _products = new List<Product>();

        // Tilføj en konstruktør der tager en List<Product>
        public Order(List<Product> products)
        {
            _products = products ?? new List<Product>(); // Sikrer at _products aldrig er null
        }

        public Order()
        {
        }

        public void AddProduct(Product p)
        {
            _products.Add(p);
        }

        public double GetValueOfProducts()
        {
            var total = _products.Sum(p => p.Value);
            return total;
        }

        public double GetValueOfProducts(DateTime Date)
        {
            double total = 0;
            foreach (var product in _products)
            {
                // Betinget operator evaluerer, om produktet er tilgængeligt i den givne periode.
                // Hvis ja, lægges produktets værdi til den samlede sum; ellers lægges 0 til.
                total += (product.AvailableFrom <= Date && product.AvailableTo >= Date) ? product.Value : 0;
            }
            return total;

            //var total = _products.Where(p => p.AvailableFrom <= Date && p.AvailableTo >= Date )
            //                     .Sum(p=> p.Value);

            //return total;
        }

        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }

        public double GetBonus(DateTime date, Func<double,double> myFunc)
        {

            return myFunc(GetValueOfProducts(date)); 

        }


        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }
        public double GetTotalPrice(DateTime date, Func<double, double> myFunc)
        {
            return GetValueOfProducts(date) - GetBonus(date, myFunc);
        }



        public List<Product> SortProductOrderByAvailableTo()
        {
            var total = _products.OrderBy(p  => p.AvailableTo).ToList();
            return total;
        }

        public List<Product> SortProductOrderBy(Func<Product, object> keySelector)
        {
            // Brug OrderBy fra LINQ med den givne keySelector for at sortere produkterne.
            // ToList() kaldet konverterer det ordnede IEnumerable<Product> tilbage til en List<Product>.
            return _products.OrderBy(keySelector).ToList();
        }
    }
}

