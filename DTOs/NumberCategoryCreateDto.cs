using OL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class NumberCategoryCreateDto : IDto
    {
        public string Definition { get; set; }
        public bool Status { get; set; }
        public string IconCode { get; set; }
        public List<ObjNumber> Numbers { get; set; }
    }
}
