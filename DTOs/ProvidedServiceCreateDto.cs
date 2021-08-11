using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class ProvidedServiceCreateDto : IDto
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
    }
}
