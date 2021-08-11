using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL
{
    public class ObjWorkingHour : BaseEntity
    {
        public string Day { get; set; }
        public string Morning { get; set; }
        public string Afternoon { get; set; }
    }
}
