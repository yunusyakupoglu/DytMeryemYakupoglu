using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL
{
    public class ObjComments : BaseEntity
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string EMail { get; set; }
        public string Description { get; set; }
    }
}
