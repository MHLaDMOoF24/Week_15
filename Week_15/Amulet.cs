using System.Xml.Linq;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        private string _design;
        private Level _quality;
        public string Design
        {
            get { return _design; }
            set { _design = value; }
        }
        public Level Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }

        public Amulet(string itemId) : base(itemId) => Quality = Level.medium;
        public Amulet(string itemId, Level quality) : base(itemId)
        {
            Quality = quality;
        }
        public Amulet(string itemId, Level quality, string design) : base(itemId)
        {
            Quality = quality;
            Design = design;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Quality: {Quality}, Design: {Design}";
        }
    }
}
