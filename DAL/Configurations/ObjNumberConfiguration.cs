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
    public class ObjNumberConfiguration : IEntityTypeConfiguration<ObjNumber>
    {
        public void Configure(EntityTypeBuilder<ObjNumber> builder)
        {
            builder.HasIndex(x => new
            {
                x.NumberCategoryId
            }).IsUnique();

            builder.Property(x => x.Definition).HasMaxLength(20).IsRequired();
            builder.HasOne(x => x.ObjNumberCategory).WithMany(x => x.Numbers).HasForeignKey(x => x.NumberCategoryId);

        }
    }
}
