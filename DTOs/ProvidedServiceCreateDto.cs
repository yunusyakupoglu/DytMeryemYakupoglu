using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class ProvidedServiceCreateDto : IDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconCode { get; set; }
        public bool Status { get; set; }
    }
}
