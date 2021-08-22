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
    public class ObjOnlineDietFaqConfiguration : IEntityTypeConfiguration<ObjOnlineDietFaq>
    {
        public void Configure(EntityTypeBuilder<ObjOnlineDietFaq> builder)
        {
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
