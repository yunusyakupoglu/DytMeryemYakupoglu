using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class ProvidedServiceListDto : IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconCode { get; set; }
        public bool Status { get; set; }

    }
}
