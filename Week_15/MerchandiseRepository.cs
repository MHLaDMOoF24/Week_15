using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }

        public Merchandise GetMerchandise(string itemId)
        {
            foreach (var merchandise in merchandises)
            {
                if (merchandise.ItemId.Contains(itemId)) 
                    return merchandise;
            }
            return null;
        }

        //public double GetTotalValue()
        //{
        //    double total = 0;
        //    foreach (Merchandise merchandise in merchandises)
        //    {
        //        if (merchandise is Amulet)
        //        {
        //            Amulet amulet = (Amulet)merchandise;
        //            total += Utility.GetValueOfMerchandise(amulet);
        //        }
        //        else if (merchandise is Book)
        //        {
        //            Book book = (Book)merchandise;
        //            total += Utility.GetValueOfMerchandise(book);
        //        }
        //    }
        //    return total;
        //}
    }
}
