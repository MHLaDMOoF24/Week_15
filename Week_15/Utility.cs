﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public static class Utility
    {
        public static double GetValueOfBook(Book book)
        {
            double Price = book.Price;
            return Price;
        }

        public static double GetValueOfAmulet(Amulet amulet)
        {
            double Price = 0;
            switch (amulet.Quality)
            {
                case Level.low:
                    Price = 12.5d;
                    break;
                case Level.medium:
                    Price = 20.0d;
                    break;
                case Level.high:
                    Price = 27.5d;
                    break;
            }
            return Price;
        }

        public static double GetValueOfCourse(Course course)
        {
            double Price = 875;
            double time = 0;

            time = course.DurationInMinutes / 60;

            if (course.DurationInMinutes == null || course.DurationInMinutes == 0)
                Price = 0;
            else
            {
                if (course.DurationInMinutes % 60 > 0)
                    time++;
                Price *= time;
            }

            return Price;
        }


    }
}