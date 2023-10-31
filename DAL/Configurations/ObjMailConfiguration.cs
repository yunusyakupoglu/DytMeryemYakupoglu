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
    public class ObjMailConfiguration : IEntityTypeConfiguration<ObjMail>
    {
        public void Configure(EntityTypeBuilder<ObjMail> builder)
        {
            builder.Property(x => x.MailAddress).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
