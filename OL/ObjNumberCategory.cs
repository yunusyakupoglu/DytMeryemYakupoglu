﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL
{
    public class ObjNumberCategory : BaseEntity
    {
        public string Definition { get; set; }
        public bool Status { get; set; }
        public List<ObjNumber> Numbers { get; set; }
    }
}
