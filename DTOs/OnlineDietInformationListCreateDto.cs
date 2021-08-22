using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class OnlineDietInformationListCreateDto : IDto
    {
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
