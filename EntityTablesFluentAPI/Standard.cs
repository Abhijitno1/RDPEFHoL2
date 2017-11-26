using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityTablesFluentAPI
{
    public class Standard
    {
        public Standard()
        {
            this.StudentList = new HashSet<Student>();
        }
        public int StandardId { get; set; }
        public string StandardName { get; set; }
        public string ClassTeacher { get; set; }
        public virtual ICollection<Student> StudentList { get; set; }
    }
}
