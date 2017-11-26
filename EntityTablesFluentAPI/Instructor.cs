using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityTablesFluentAPI
{
    public class Instructor
    {
        public Instructor()
        {
            this.Courses = new List<Course>();
        }
        public int InstructorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public virtual ICollection<Course> Courses { get; private set; }
        public virtual OfficeAssignment Office { get; set; }
    }
}
