using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class WeakenedCreateDto : IDto
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Month { get; set; }

        public string FilePath { get; set; }
        public IFormFile FileDoc { get; set; }
        public bool Status { get; set; }

    }
}
