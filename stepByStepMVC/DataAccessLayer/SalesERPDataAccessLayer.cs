using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using stepByStepMVC.Models;

namespace stepByStepMVC.DataAccessLayer
{
    public class SalesERPDataAccessLayer : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TableOfEmployees");
            base.OnModelCreating(modelBuilder);
        }
    }
}
