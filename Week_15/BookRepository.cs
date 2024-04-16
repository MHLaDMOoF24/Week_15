using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class BookRepository
    {
        private List<Book> books = new List<Book>();
        //private Utility utility;    // new Utility? Check later if working!

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book GetBook(string itemId)
        {
            foreach (var book in books)
            {
                if (book.ItemId.Contains(itemId)) 
                    return book;
            }
            return null;
        }

        public double GetTotalValue()
        {
            double total = 0;
            foreach (Book book in books)
            {
                total += Utility.GetValueOfBook(book);
            }
            return total;
        }
    }
}
