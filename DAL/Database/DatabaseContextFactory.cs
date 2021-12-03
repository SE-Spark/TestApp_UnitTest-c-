using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DAL.Database
{
    class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var optsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optsBuilder.UseSqlServer("Server=(local)\\SQL2019;Initial Catalog=UnitTestDb;User Id=superadmin;Password=samuel4300;");
            return new DatabaseContext(optsBuilder.Options);
        }
    }
}
