using InfocusCase.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfocusCase.DataAccess.Concrete.EntityFramework
{
    public class InfocusCaseDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-AV372PO\SQLEXPRESS;Database=InfocusCaseDb;Trusted_Connection=true");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<PersonTask>().HasKey(c => new { c.PersonId, c.TaskId });
        //}

        public DbSet<Person> People { get; set; }
        public DbSet<PersonAddress> PersonAddresses { get; set; }
        public DbSet<PersonTask> PersonTasks { get; set; }
        public DbSet<InfocusCase.Entity.Concrete.Task> Tasks { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
    }
}
