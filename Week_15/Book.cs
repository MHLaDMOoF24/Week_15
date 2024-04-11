namespace Disaheim
{
    public class Book : Merchandise
    {
        private string _title;
        private double _price;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Book(string itemId) : base(itemId)
        {
        }
        public Book(string itemId, string title) : base(itemId)
        {
            _title = title;
        }
        public Book(string itemId, string title, double price) : base(itemId)
        {
            _title = title;
            _price = price;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }
}
