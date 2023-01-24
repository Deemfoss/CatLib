using CatLib.Models.NameGenerator;
using CatLib.Models.Products;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models
{
    public class CatLibContext : DbContext
    {
       
        public DbSet<Cat> Cats { get; set; }
        public DbSet<MainSpecification> MainSpecifications { get; set; }
        public DbSet<OtherSpecification> OtherSpecifications { get; set; }
        public DbSet<PhysicalSpecification> PhysicalSpecifications { get; set; }

        //Generator Name
        public DbSet<CatGeneratorName> CatGeneratorNames { get; set; }
        public DbSet<CatGeneratorType> CatGeneratorTypes { get; set; }
       
       
        public DbSet<TemperamentDescription> TemperamentDescriptions { get; set; }
        public DbSet<CompatibilityDescription> CompatibilityDescription { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Hair> Hair { get; set; }
        public DbSet<Personality> Personality { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<News> News { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }


        public CatLibContext(DbContextOptions<CatLibContext> options) : base(options)
        {
            //Database.EnsureDeleted();
           // Database.EnsureCreated();
        }

    }
  
}
