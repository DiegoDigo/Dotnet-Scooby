using System;
using Microsoft.EntityFrameworkCore;
using Scooby.Infra.Map;
using Scooby.Domain.Entity;

namespace Scooby.Infra.EFCore
{
    public class ScoobyContext : DbContext
    {

        public ScoobyContext(DbContextOptions<ScoobyContext> options) : base(options) { }
        public DbSet<Brand> Brands { get; private set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BrandMap());
            builder.ApplyConfiguration(new FamilyMap());
            builder.ApplyConfiguration(new CategoryMap());
            builder.ApplyConfiguration(new ProductMap());
        }
    }
}
