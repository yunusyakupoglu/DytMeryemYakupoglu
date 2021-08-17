using Microsoft.AspNetCore.Mvc.Rendering;
using OL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class NumberUpdateDto : IUpdateDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public bool Status { get; set; }
        public SelectList NumberCategories { get; set; }

        public int NumberCategoryId { get; set; }
        public ObjNumberCategory ObjNumberCategory { get; set; }
    }
}
