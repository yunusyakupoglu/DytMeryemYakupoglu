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
    public class ObjWorkingHourConfiguration : IEntityTypeConfiguration<ObjWorkingHour>
    {
        public void Configure(EntityTypeBuilder<ObjWorkingHour> builder)
        {
            builder.Property(x => x.Day).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Morning).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Afternoon).HasMaxLength(20).IsRequired();
        }
    }
}
