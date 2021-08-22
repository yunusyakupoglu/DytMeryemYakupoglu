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
    public class ObjWeakenedConfiguration : IEntityTypeConfiguration<ObjWeakened>
    {
        public void Configure(EntityTypeBuilder<ObjWeakened> builder)
        {
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.SurName).IsRequired();
            builder.Property(x => x.Month).IsRequired();
            builder.Property(x => x.FilePath).IsRequired();
            builder.Property(x => x.Status).IsRequired();

        }
    }
}
