using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class AmuletRepository
    {
        private List<Amulet> amulets = new List<Amulet>();
        //private Utility utility;    // new Utility? Check later if working!

        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public Amulet GetAmulet(string itemId)
        {
            foreach (var amulet in amulets)
            {
                if (amulet.ItemId.Contains(itemId))
                    return amulet;
            }
            return null;
        }

        public double GetTotalValue()
        {
            double total = 0;
            foreach (Amulet amulet in amulets)
            {
                total += Utility.GetValueOfAmulet(amulet);
            }
            return total;
        }
    }
}
