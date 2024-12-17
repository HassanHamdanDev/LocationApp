using LocationApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Infrastructure.EntityFramework
{
    public class LocationAppDbContext : DbContext
    {
        public DbSet<Place> Places { get; set; }

        public LocationAppDbContext()
        {
        }

        public LocationAppDbContext(DbContextOptions<LocationAppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=LocationApp;Trusted_Connection=True;Encrypt=False;");
        }
    }
}
