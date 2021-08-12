﻿using OL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class NumberCreateDto : IDto
    {
        public string Definition { get; set; }
        public int NumberCategoryId { get; set; }
        public ObjNumberCategory ObjNumberCategory { get; set; }
    }
}