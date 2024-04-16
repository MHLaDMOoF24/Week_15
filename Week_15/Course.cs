using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
        private string _name;
        private int _durationInMinutes;

        public static double CourseHourValue = 875.0;

        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }
        public int DurationInMinutes
        {
            get { return _durationInMinutes; }
            set { _durationInMinutes = value; }
        }

        public Course(string name) : this(name, 0) { }
        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}";
        }

        public virtual double GetValue()
        {
            double price = 0;
            double time = 0;

            time = DurationInMinutes / 60;

            if (DurationInMinutes != null || DurationInMinutes != 0)
            {
                if (DurationInMinutes % 60 > 0)
                    time++;
                price = time * CourseHourValue;
            }

            return price;
        }
    }
}
