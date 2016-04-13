using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FitFriend.Models
{
    public class FitDBContext : DbContext
    {
        public FitDBContext(): base("SQLAzureConnection")
        {
            Database.SetInitializer<FitDBContext>(new DropCreateDatabaseIfModelChanges<FitDBContext>());
        }
        public DbSet<Food> Food { get; set; }
        public DbSet<Exercises> Exercises { get; set; }
    }
}