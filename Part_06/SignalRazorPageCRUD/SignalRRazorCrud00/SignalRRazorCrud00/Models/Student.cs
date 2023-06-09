﻿using System;
using System.Collections.Generic;

namespace SignalRRazorCrud00.Models
{
    public partial class Student
    {
        public Student()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public int Id { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
