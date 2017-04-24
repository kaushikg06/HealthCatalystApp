using HealthCatalystApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HealthCatalystApp.DAL
{
    /// <summary>
    /// Data Access Layer for Health Catalyst App
    /// </summary>
    public class PeopleContext : DbContext
    {
        public PeopleContext() : base("PeopleContext")
        {
        }

        public DbSet<People> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Removes pluralization of table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}