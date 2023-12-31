﻿using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Reference : CoreEntity
    {
        public string ReferenceName { get; set; }
        public ICollection<ReferenceImage> ReferenceImages { get; set; }
    }
}
