using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {

		//private string itemId;

		//public string ItemId
		//{
		//	get { return itemId; }
		//	set { itemId = value; }
		//}

		private string design;

		public string Design
		{
			get { return design; }
			set { design = value; }
		}

        public Level Quality { get; set; }

        public Amulet(string itemId)
        {
            this.ItemId = itemId;
            Quality = Level.medium;

        }


        public Amulet(string itemId, Level Quality):this(itemId)
        {
            this.Quality = Quality;
        }

        public Amulet(string itemId, Level Quality, string Design):this(itemId,Quality)
        {
            
            this.Design = Design;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
        public override double GetValue()
        {
            if (Quality == Level.low)
            {
                return 12.5;
            }
            else if (Quality == Level.medium)
            {
                return 20.0;
            }
            else
            {
                return 27.5;
            }

        }


    }
}
