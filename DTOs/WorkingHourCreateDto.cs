using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class WorkingHourCreateDto : IDto
    {
        public string Day { get; set; }
        public string Morning { get; set; }
        public string Afternoon { get; set; }
        public bool Status { get; set; }

    }
}
