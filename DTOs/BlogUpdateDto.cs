using OL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class BlogUpdateDto : IUpdateDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public ObjCategory ObjCategory { get; set; }
        public List<ObjBlogAppUser> BlogAppUsers { get; set; }
    }
}
