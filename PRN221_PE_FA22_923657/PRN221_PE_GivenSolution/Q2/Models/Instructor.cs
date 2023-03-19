using System;
using System.Collections.Generic;

namespace Q2.Models
{
    public partial class Instructor
    {
        public Instructor()
        {
            Departments = new HashSet<Department>();
            CoursesCourses = new HashSet<Course>();
        }

        public int Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public DateTime HireDate { get; set; }

        public virtual OfficeAssignment? OfficeAssignment { get; set; }
        public virtual ICollection<Department> Departments { get; set; }

        public virtual ICollection<Course> CoursesCourses { get; set; }
    }
}
