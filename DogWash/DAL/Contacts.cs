using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DogWash.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DogWash.DAL
{
    public class Contacts:DbContext
    {
        public Contacts():base("Contacts")
        {

        } 
        public DbSet<Person> people { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}