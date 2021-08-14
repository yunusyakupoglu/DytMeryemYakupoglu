﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class SocialMediaAccountCreateDto : IDto
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string IconCode { get; set; }
        public bool Status { get; set; }

    }
}
