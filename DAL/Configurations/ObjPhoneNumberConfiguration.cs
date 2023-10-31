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
    public class ObjPhoneNumberConfiguration : IEntityTypeConfiguration<ObjPhoneNumber>
    {
        public void Configure(EntityTypeBuilder<ObjPhoneNumber> builder)
        {
            builder.Property(x => x.Definition).IsRequired();
        }
    }
}
