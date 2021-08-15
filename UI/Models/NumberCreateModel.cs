using Microsoft.AspNetCore.Mvc.Rendering;
using OL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Models
{
    public class NumberCreateModel
    {
        public string Definition { get; set; }
        public int NumberCategoryId { get; set; }
        public ObjNumberCategory ObjNumberCategory { get; set; }
        public SelectList NumberCategories { get; set; }
    }
}
