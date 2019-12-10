using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFV4Console
{
    class EFContext : DbContext
    {

        public EFContext() : base()
        {
            //Database.SetInitializer<EFContext>(new CreateDatabaseIfNotExists<EFContext>());
            Database.SetInitializer<EFContext>(new DropCreateDatabaseIfModelChanges<EFContext>());
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
    }




}
