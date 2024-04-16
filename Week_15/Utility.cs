using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public static class Utility
    {
        public static double LowQualityValue = 12.5;
        public static double MediumQualityValue = 20.0;
        public static double HighQualityValue = 27.5;
        public static double CourseHourValue = 875.0;

        public static double GetValueOfMerchandise(Amulet amulet)
        {
            double price = 0;
            switch (amulet.Quality)
            {
                case Level.low:
                    price = 12.5d;
                    break;
                case Level.medium:
                    price = 20.0d;
                    break;
                case Level.high:
                    price = 27.5d;
                    break;
            }
            return price;
        }
        public static double GetValueOfMerchandise(Book book)
        {
            double price = book.Price;

            return price;
        }

        public static double GetValueOfCourse(Course course)
        {
            double price = 0;
            double time = 0;

            time = course.DurationInMinutes / 60;

            if (course.DurationInMinutes != null || course.DurationInMinutes != 0)
            {
                if (course.DurationInMinutes % 60 > 0)
                    time++;
                price = time * CourseHourValue;
            }

            return price;
        }


    }
}
