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
    public class ObjBlogCategoryConfiguration : IEntityTypeConfiguration<ObjBlogCategory>
    {
        public void Configure(EntityTypeBuilder<ObjBlogCategory> builder)
        {
            throw new NotImplementedException();
        }
    }
}
