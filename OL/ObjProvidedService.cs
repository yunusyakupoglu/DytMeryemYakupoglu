using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL
{
    public class ObjProvidedService : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconCode { get; set; }
        public bool Status { get; set; }

    }
}
