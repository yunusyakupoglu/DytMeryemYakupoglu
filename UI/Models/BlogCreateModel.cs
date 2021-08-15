using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using OL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Models
{
    public class BlogCreateModel
    {
        public string Title { get; set; }
        public bool Status { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public IFormFile FileDoc { get; set; }
        public int CategoryId { get; set; }
        public ObjCategory ObjCategory { get; set; }
        public SelectList Categories { get; set; }
        public List<ObjBlogAppUser> BlogAppUsers { get; set; }
    }
}
