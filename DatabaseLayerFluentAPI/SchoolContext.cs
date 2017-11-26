using EntityTablesFluentAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayerFluentAPI
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolDBConnection") {
            Database.SetInitializer(new SchoolDbInitializer());
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
                
            modelBuilder.Entity<OfficeAssignment>().HasKey(oa => oa.InstructorId)
                .Property(oa => oa.InstructorId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<OfficeAssignment>().HasRequired(oa => oa.Instructor).WithRequiredDependent(ins => ins.Office);
            modelBuilder.Configurations.Add(new DepartmentConfig());
            modelBuilder.Entity<Course>().HasRequired(co => co.Department).WithMany(dept => dept.Courses).Map(co => co.MapKey("DepartmentIdFK"));
            modelBuilder.ComplexType<Details>().Property(det => det.Location).HasMaxLength(20);
            //modelBuilder.Entity<OnsiteCourse>().Property(co => co.Details.Location).HasMaxLength(20); //Alternative way
            modelBuilder.Entity<OfficeAssignment>().Property(oa => oa.TimeStamp).IsRowVersion(); //.IsConcurrencyToken();
            modelBuilder.Entity<Student>().HasRequired(stu => stu.Standard).WithMany(std => std.StudentList).HasForeignKey(stu => stu.StdId);
            //modelBuilder.Entity<Standard>().HasMany(std => std.StudentList).WithRequired(stu => stu.Standard).HasForeignKey(stu => stu.StdId); //Alternative way
            modelBuilder.Entity<StudentAddress>().HasKey(stu => stu.StudentId);
            modelBuilder.Entity<StudentAddress>().Property(stu => stu.StudentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Student>().HasRequired<StudentAddress>(stu => stu.Address).WithRequiredPrincipal(ad => ad.Student);
        }
    }
}
