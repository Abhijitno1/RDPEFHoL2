﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTablesFluentAPI
{
    public class Course
    {
        public Course()
        {
            this.Instructors = new HashSet<Instructor>();
        }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        //public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Instructor> Instructors { get; private set; }
    }
}
