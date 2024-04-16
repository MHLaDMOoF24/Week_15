using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public abstract class Merchandise : IValuable
    {
        private string _itemId;

        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        public Merchandise(string itemId)
        {
            ItemId = itemId;
        }

        public virtual string ToString()
        {
            return $"ItemId: {ItemId}";
        }

        public abstract double GetValue();
    }
}
