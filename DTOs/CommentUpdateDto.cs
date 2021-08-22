using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class CommentUpdateDto : IUpdateDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string EMail { get; set; }
        public string InstagramAccount { get; set; }
        public string Job { get; set; }

        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
