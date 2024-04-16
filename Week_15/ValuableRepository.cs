using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            foreach (IValuable valuable in valuables)
            {
                if (valuable is Merchandise merchandise && merchandise.ItemId.Contains(id))
                    return merchandise;

                if (valuable is Course course && course.Name.Contains(id))
                    return course;
            }
            return null;
        }

        public double GetTotalValue()
        {
            double total = 0;
            foreach (IValuable valuable in valuables)
            {
                total += valuable.GetValue();
            }
            return total;
        }

        public int Count()
        {
            return valuables.Count;
        }
    }
}
