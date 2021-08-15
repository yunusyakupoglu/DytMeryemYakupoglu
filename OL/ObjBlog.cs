using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL
{
    public class ObjBlog : BaseEntity
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }
        public ObjCategory ObjCategory { get; set; }
        //public ICollection<ObjCategory> ObjCategories { get; set; }
        public List<ObjBlogAppUser> BlogAppUsers { get; set; }
        public bool Status { get; set; }

    }
}
