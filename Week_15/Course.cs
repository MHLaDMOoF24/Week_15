using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course
    {
        private string _name;
        private int _durationInMinutes;

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

        public Course(string name)
        {
            Name = name;
        }
        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
        }
    }
}
