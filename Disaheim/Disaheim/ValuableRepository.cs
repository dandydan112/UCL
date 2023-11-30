using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValuableRepository
    {

        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string id)
        {
            foreach (var valuable in valuables)
            {
                if (valuable is Merchandise merchandise)
                {
                    if (id == merchandise.ItemId)
                    {
                        return valuable;
                    }

                }
                else if (valuable is Course course)
                {
                    if (id == course.Name)
                    {
                        return course;
                    }
                }

            }
            return null;

        }
        public double GetTotalValue()
        {
            Utility utility = new Utility();


            double total = 0;
            foreach (var valuable in valuables)
            {
                if (valuable is Merchandise merchandise)
                {
                    Amulet amulet = merchandise as Amulet;
                    if (amulet != null)
                    {
                        total += amulet.GetValue();
                    }
                    else if (valuable is Book book)
                    {
                        total += book.GetValue();
                    }

                }
                else if (valuable is Course course)
                {
                    total += course.GetValue();
                }

            }
             return total;
        }
        public int Count()
        {
            int count = 0;
            foreach (var valuable in valuables)
            {
                count++;
            }
            return count;
        }

    }
}