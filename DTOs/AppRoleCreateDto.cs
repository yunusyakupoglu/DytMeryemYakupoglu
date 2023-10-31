using System;
using System.Collections.Generic;
using System.Text;
using OL;

namespace DTOs
{
    public class AppRoleCreateDto : IDto
    {
        public string Definition { get; set; }
        public bool Status { get; set; }

    }
}
