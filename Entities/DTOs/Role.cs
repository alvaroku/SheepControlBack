﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class RoleRequest : ObjetoBase
    {
        public string Name { get; set; }
    }
    public class RoleResponse : ObjetoBase
    {
        public string Name { get; set; }
    }
}
