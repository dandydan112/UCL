using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class BookRepository : Controller
    {

        

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public Book? GetBook(string itemId)
        {
            foreach (Book book in Books)
            {
                if (itemId == book.ItemId)
                    return book;


            }
            return null;
        }

        public double GetTotalValue()
        {
            Utility utility = new Utility();
            double total = 0;
            foreach (Book book in Books)
            {
                total += utility.GetValueOfBook(book);
            }
            return total;
            
            
            //double total = 0;
            //foreach (Book book in Books)
            //{
            //    total += book.Price;
            //}
            //return total;
        }


    }




}

