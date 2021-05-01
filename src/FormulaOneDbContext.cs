using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCoreSmartEnum
{
    public class FormulaOneDbContext : DbContext
    {
        public DbSet<Driver> Drivers { get; set; }

        public FormulaOneDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Driver>()
                .Property(driver => driver.Status)
                .HasDefaultValue(Status.Unknown)
                .HasConversion(
                    status => status.Name,
                    status => Status.Find(status));
        }
    }
}
