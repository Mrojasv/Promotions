using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApplicationData.Models.ModelConfiguration
{
    public class PromotionConfiguration : IEntityTypeConfiguration<ConfigPromotion>
    {

        public void Configure(EntityTypeBuilder<ConfigPromotion> builder)
        {
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.CreateOn).IsRequired();
            builder.Property(prop => prop.CustomerName).HasMaxLength(100).IsRequired();
            builder.Property(prop => prop.NumberPrizes).IsRequired();
            builder.Property(prop => prop.TotalPrize).IsRequired();
        }
    }
}
