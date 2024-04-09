namespace Disaheim
{
    public class Amulet
    {
        private string _itemId;
        private string _design;
        private Level _quality;
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
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
            _itemId = itemId;
        }
        public Amulet(string itemId, Level quality)
        {
            _itemId = itemId;
            _quality = quality;
        }
        public Amulet(string itemId, Level quality, string design)
        {
            _itemId = itemId;
            _quality = quality;
            _design = design;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }

    }
}
