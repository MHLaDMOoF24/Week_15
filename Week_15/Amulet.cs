using System.Diagnostics;
using System.Xml.Linq;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        private string _design;
        private Level _quality;

        public static double LowQualityValue = 12.5;
        public static double MediumQualityValue = 20.0;
        public static double HighQualityValue = 27.5;

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

        public override double GetValue()
        {
            switch (Quality)
            {
                case Level.low:
                    return LowQualityValue;
                case Level.medium:
                    return MediumQualityValue;
                case Level.high:
                    return HighQualityValue;
                default:    // Come to think of it, maybe this should be medium? As that's our defaulting quality?
                    return 0;   // Ya dun goofed if this somehow happens!
            }
        }
    }
}
