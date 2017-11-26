using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTablesFluentAPI
{
    public class OfficeAssignment
    {
        public int InstructorId { get; set; }
        public string Location { get; set; }
        public Byte[] TimeStamp { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}
