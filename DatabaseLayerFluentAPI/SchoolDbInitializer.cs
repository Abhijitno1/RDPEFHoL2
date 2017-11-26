using EntityTablesFluentAPI;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DatabaseLayerFluentAPI
{
    public class SchoolDbInitializer : DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var dept = new[] {
            new Department
            {
                DepartmentId = 1,
                Name = "Physics",
                Administrator = 1,
                StartDate = new DateTime(2012, 12, 21),
                Budget = 30000
            },
            new Department
            {
                DepartmentId = 2,
                Name = "Computer Science",
                Administrator = 1,
                StartDate = new DateTime(2013, 12, 21),
                Budget = 30000
            }
            };
            context.Departments.AddRange(dept);

            StudentAddress studAddr = new StudentAddress() { Address1 = "Addr1", Address2 = "Addr2", City = "City1", State = "State1", Zip = 12312, Country = "XYZ" };
            Standard fourth = new Standard { StandardName = "IV", ClassTeacher = "Ms. Bhavani" };
            Student vaishu = new Student() { StudentName = "Vaishnavi", Address = studAddr, Standard = fourth };
            context.Students.Add(vaishu);

            base.Seed(context);
        }
    }
}
