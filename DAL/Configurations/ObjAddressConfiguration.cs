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
    public class ObjAddressConfiguration : IEntityTypeConfiguration<ObjAddress>
    {
        public void Configure(EntityTypeBuilder<ObjAddress> builder)
        {
            builder.Property(x => x.Description).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Coordinate).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
