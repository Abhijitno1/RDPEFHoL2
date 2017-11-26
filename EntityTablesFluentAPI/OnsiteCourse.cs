using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTablesFluentAPI
{
    public class OnsiteCourse : Course
    {
        public OnsiteCourse()
        {
            this.Details = new Details();
        }
        public Details Details { get; set; }
    }
}
