using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class DataBaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;DataBase=ReCapProject;Trusted_Connection=true");
        }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Car> Cars { get; set; }
        
        public DbSet<Color> Colors { get; set; }
    }
}
