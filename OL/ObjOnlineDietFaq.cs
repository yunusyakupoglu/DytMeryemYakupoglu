﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL
{
    public class ObjOnlineDietFaq : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
