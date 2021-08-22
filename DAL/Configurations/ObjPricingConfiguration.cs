using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class ObjPricingConfiguration : IEntityTypeConfiguration<ObjPricing>
    {
        public void Configure(EntityTypeBuilder<ObjPricing> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(3000).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
