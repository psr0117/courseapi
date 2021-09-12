using courseapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace courseapi.Services
{
    public class CourseService
    {
        public List<Course> courseList;

        public CourseService ()
        {
            courseList = new List<Course>()
            {
                new Course() {CourseID = 1, CourseName = "AZ-204" },
                new Course() {CourseID = 2, CourseName = "AZ-303" },
                new Course() {CourseID = 3, CourseName = "AZ-304" }
            };
        }

        public IEnumerable<Course> GetCourses()
        {
            return (courseList);
        }
    }
}
