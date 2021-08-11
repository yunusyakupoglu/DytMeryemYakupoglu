using OL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class AppRoleUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public List<ObjAppUserRole> AppUserRoles { get; set; }

    }
}
