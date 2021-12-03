using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Database
{
    public class DatabaseContext:DbContext
    {
        
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(local)\\SQL2019;Initial Catalog=UnitTestDb;User Id=superadmin;Password=samuel4300;");
            }
        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Login> logins { get; set; }
        public DbSet<Designation> designations { get; set; }
        public DbSet<Payment> payments { get; set; }

    }
}
