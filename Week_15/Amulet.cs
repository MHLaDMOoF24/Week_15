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

        public Amulet(string itemId)
        {
            ItemId = itemId;
        }
        public Amulet(string itemId, Level quality)
        {
            ItemId = itemId;
            Quality = quality;
        }
        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}
