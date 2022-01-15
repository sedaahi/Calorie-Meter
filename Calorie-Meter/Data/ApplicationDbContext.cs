using Calori_Meter.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_Meter.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("CalorieDatabase")
        {

        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Repast> Repasts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RepastFoodDetail> RepastFoodDetails { get; set; }
    }
}
