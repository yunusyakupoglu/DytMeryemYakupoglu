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
    public class ObjCommentConfiguration : IEntityTypeConfiguration<ObjComment>
    {
        public void Configure(EntityTypeBuilder<ObjComment> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Lastname).HasMaxLength(100).IsRequired();
            builder.Property(x => x.EMail).HasMaxLength(100).IsRequired();
            builder.Property(x => x.InstagramAccount).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Job).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1500).IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
