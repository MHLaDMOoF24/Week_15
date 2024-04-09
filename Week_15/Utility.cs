using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            double Price = book.Price;
            return Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            double Price = 0;
            switch (amulet.Quality)
            {
                case Level.low:
                    Price = 12.5d;
                    break;
                case Level.medium:
                    Price = 20.0d;
                    break;
                case Level.high:
                    Price = 27.5d;
                    break;
            }
            return Price;
        }
    }
}
