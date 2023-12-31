﻿using Entities.Models;
using Services.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Services.Contracts
{
    public interface IReferenceImageService : IService<ReferenceImage>
    {
        void SetFalse(List<ReferenceImage> referenceImages);
    }
}
