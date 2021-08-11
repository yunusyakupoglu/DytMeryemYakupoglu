using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class MailListDto : IDto
    {
        public int Id { get; set; }
        public string MailAddress { get; set; }

    }
}
