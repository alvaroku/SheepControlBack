﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Vaccine:ObjetoBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string DoseApplied { get; set; } // 1 ml
        public string Photo { get; set; }
    }
}
