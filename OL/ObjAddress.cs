using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL
{
    public class ObjAddress : BaseEntity
    {
        public string Description { get; set; }
        public string Coordinate { get; set; }
        public bool Status { get; set; }
    }
}
