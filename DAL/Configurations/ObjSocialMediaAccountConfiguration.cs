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
    public class ObjSocialMediaAccountConfiguration : IEntityTypeConfiguration<ObjSocialMediaAccount>
    {
        public void Configure(EntityTypeBuilder<ObjSocialMediaAccount> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Url).HasMaxLength(500).IsRequired();
            builder.Property(x => x.IconCode).HasMaxLength(50).IsRequired();
        }
    }
}
