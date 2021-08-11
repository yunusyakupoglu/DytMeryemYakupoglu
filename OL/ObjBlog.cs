using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL
{
    public class ObjBlog : ObjBaseEntity
    {
        public string Title { get; set; }
        public bool Status { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<ObjBlogAppUser> BlogAppUsers { get; set; }
    }

    //public class ObjBlogConfiguration : IEntityTypeConfiguration<ObjBlog>
    //{
    //    public void Configure(EntityTypeBuilder<ObjBlog> builder)
    //    {
    //        builder.Property(x => x.Title).HasMaxLength(250).IsRequired();
    //        builder.Property(x => x.Description).HasColumnType("ntext").IsRequired();
    //        builder.Property(x => x.CreatedDate).HasDefaultValueSql("getDate()");
    //        builder.Property(x => x.ImagePath).HasMaxLength(500).IsRequired();
    //    }
    //}
}
