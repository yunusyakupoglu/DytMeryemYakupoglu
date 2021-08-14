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
    public class ObjNumberCategoryConfiguration : IEntityTypeConfiguration<ObjNumberCategory>
    {
        public void Configure(EntityTypeBuilder<ObjNumberCategory> builder)
        {
            builder.Property(x => x.Definition).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
