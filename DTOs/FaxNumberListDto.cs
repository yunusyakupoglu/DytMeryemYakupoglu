﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class FaxNumberListDto :IDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public bool Status { get; set; }
    }
}
