﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementations
{
    public class SheepRepository : BaseRepository<Sheep>
    {
        public SheepRepository(SheepControlDbContext context) : base(context)
        {
        }
    }
}
