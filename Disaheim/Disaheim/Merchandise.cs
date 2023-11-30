using System;
//using System.Collections.Generic;
//using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    abstract public class Merchandise : IValuable
    {
        public static double LowQualityValue { get; set; } = 12.5;

        public static double MediumQualityValue { get; set; } = 20.0;

        public static double HighQualityValue { get; set; } = 27.5;

        private string itemId;

        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        //public Merchandise(string itemId)
        //{
        //    this.itemId = itemId;
        //}

        abstract public double GetValue();




        public override string ToString()
        {
            return $"ItemId: {ItemId}";
        }
    }
}
