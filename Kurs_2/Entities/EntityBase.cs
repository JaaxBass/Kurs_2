﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_2.Entities
{
    public abstract class EntityBase : IEntity
    {
        public int Id { get; set; }
    }
}
