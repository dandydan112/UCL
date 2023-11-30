using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class MerchandiseRepository 
    {
        private List<Merchandise>  Merchandises = new List<Merchandise>();

        public List<Merchandise> AddMerchandise(Merchandise merchandise)
        {
            Merchandises.Add(merchandise);
            return Merchandises;
        }

        public Merchandise GetMerchandise(string itemId)
        {
            foreach (Merchandise merchandise in Merchandises)
            {
                if (itemId == merchandise.ItemId) return merchandise;
            }
            return null;
        }

        public double GetTotalValue()
        {
            Utility utility = new Utility();

            double total = 0;
            foreach (Merchandise merchandise in Merchandises )
            {
                Amulet amulet = merchandise as Amulet;
                if( amulet != null)
                {
                    total += utility.GetValueOfAmulet(amulet);
                }
                Book book = merchandise as Book;
                if ( book != null)
                {
                    total += utility.GetValueOfBook(book);
                }

            }
            return total;

        }
    }
}