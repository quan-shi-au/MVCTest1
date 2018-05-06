using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTest1.Models
{
    public class DBConnectionContext : DbContext
    {
        public DBConnectionContext() : base ("DefaultConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges
            <DBConnectionContext>());
        }

        public DbSet<Employee> Employees { get; set; }
    }
}

