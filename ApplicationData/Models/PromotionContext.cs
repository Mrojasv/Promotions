using System;
using ApplicationData.Models.ModelConfiguration;
using Microsoft.EntityFrameworkCore;

namespace ApplicationData.Models
{
    public class PromotionContext : DbContext
    {
        public PromotionContext(DbContextOptions<PromotionContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfiguration(new PromotionConfiguration());

        public DbSet<ConfigPromotion> ConfigPromotion { get; set; }
    }
}
