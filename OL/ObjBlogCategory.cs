using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL
{
    public class ObjBlogCategory : BaseEntity
    {
        public int BlogId { get; set; }
        public ObjBlog Blog { get; set; }
        public int CategoryId { get; set; }
        public ObjCategory Category { get; set; }
    }
}
