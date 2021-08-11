using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL
{
    public class ObjNumber : BaseEntity
    {
        public string Definition { get; set; }
        public int NumberCategoryId { get; set; }
        public ObjNumberCategory ObjNumberCategory { get; set; }
    }
}
