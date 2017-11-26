using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EntityTablesFluentAPI;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayerFluentAPI
{
    public class DepartmentConfig : EntityTypeConfiguration<Department>
    {
        public DepartmentConfig()
        {
            //HasKey(dept => new { dept.DepartmentId, dept.Name }); //Composite Primary Key
            Property(dept => dept.DepartmentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(dept => dept.Name).HasMaxLength(50);
            Property(dept => dept.Name).IsRequired();
            Property(dept => dept.Name).HasColumnName("DepartmentName");
            Ignore(dept => dept.Budget);
            Property(dept => dept.Name).IsUnicode(false);
            Property(dept => dept.StartDate).HasColumnType("smalldatetime");
        }
    }
}
