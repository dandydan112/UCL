using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class AmuletRepository : Controller
    {
        public void AddAmulet(Amulet amulet)
        {
            Amulets.Add(amulet);
        }


        public Amulet? GetAmulet(string itemId)
        {
            foreach (Amulet amulet in Amulets)
            {
                if (itemId == amulet.ItemId)
                {
                    return amulet;
                }
            }
            return null;
        }
        public double GetTotalValue()
        {
            double total = 0;
            Utility utility = new Utility();

            foreach (Amulet amulet in Amulets)
            {
                total += utility.GetValueOfAmulet(amulet);
                
                //if (amulet.Quality == Level.low)
                //{
                //    total += 12.5;
                //}
                //else if (amulet.Quality == Level.medium)
                //{
                //    total += 20.0;
                //}
                //else
                //{
                //    total += 27.5;
                //}

            }
            return total;
        }



    }
}
