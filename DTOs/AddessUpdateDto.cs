using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class AddessUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Coordinate { get; set; }
    }
}
