using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTablesFluentAPI
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        public int StdId { get; set; }
        //[ForeignKey("StdId")]
        public virtual Standard Standard { get; set; }
        public virtual StudentAddress Address { get; set; }
    }
}
