using DatabaseLayerFluentAPI;
using EntityTablesFluentAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerFluentAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations.DisplayDepartments();
        }
    }

    class Operations
    {
        public static void DisplayDepartments()
        {
            using (SchoolContext context = new SchoolContext())
            {
                context.Departments.ToList().ForEach(dept =>
                    Console.WriteLine(dept.Name));
            }
        }
    }
}
