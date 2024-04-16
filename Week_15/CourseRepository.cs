using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class CourseRepository
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourse(string name)
        {
            foreach (var course in courses)
            {
                if (course.Name.Contains(name))
                    return course;
            }
            return null;
        }

        public double GetTotalValue()
        {
            double total = 0;
            foreach (Course course in courses)
            {
                total += Utility.GetValueOfCourse(course);
            }
            return total;
        }
    }
}
