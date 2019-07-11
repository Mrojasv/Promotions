using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApplicationData.Models.ModelConfiguration
{
    public class PromotionConfiguration : IEntityTypeConfiguration<ConfigPromotion>
    {
        public PromotionConfiguration(EntityTypeBuilder<ConfigPromotion> builder)
        {
            builder.HasKey(prop => prop.Id);
            //builder.Property(prop => prop.CreateOn).HasColumnType("TIMESTAMP(0)")
        }
    }
}
