using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise
    {

		//private string itemId;

		//public string ItemId
		//{
		//	get { return itemId; }
		//	set { itemId = value; }
		//}

		private string title;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		private double price;

		public double Price
		{
			get { return price; }
			set { price = value; }
		}

		public Book(string itemId) 
		{
			this.ItemId = itemId;
		}

		public Book(string itemId, string title) : this(itemId)
        {
           
			this.title = title;
        }

        public Book(string itemId, string title, double price) : this(itemId, title)
        {
			this.price = price;
        }

        public override string ToString()
        {
			return $"ItemId: {ItemId}, Title: {title}, Price: {price}";
        }

        public override double GetValue()
        {
            return Price;
        }





    }
}
