using AppointmentCRUD;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD.Classes
{
    public class Context : DbContext
    {
        //1-------->    On Model(DataBase) Configuring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "Data Source=.;" +
                "Initial Catalog=399_Batch;" +
                "Trusted_Connection = True");
            //1. Data Source = .,   ====> SQL Server
            //2. Initial Catalog = ""
            //3. Trusted_Connection = Always True
        }

        //2---------->    On Model Creating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        //3. DbSet( All C Sharp Class Whoes Tables Are to be Generated)
        //Imp====> Call CRUD
        public DbSet<Appointment>? appointments { get; set; }
    }
}
