﻿using System;
using System.Collections.Generic;
using System.Text;
using OL;

namespace DTOs
{
    public class AppRoleCreateDto : IDto
    {
        public string Definition { get; set; }
        public List<ObjAppUserRole> AppUserRoles { get; set; }

    }
}
