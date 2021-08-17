using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL
{
    public class ObjWeakened : BaseEntity
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string FilePath { get; set; }
        [NotMapped]
        public IFormFile FileDoc { get; set; }
    }
}
