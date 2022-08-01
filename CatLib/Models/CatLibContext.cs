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

        public CatLibContext(DbContextOptions<CatLibContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
  
}
