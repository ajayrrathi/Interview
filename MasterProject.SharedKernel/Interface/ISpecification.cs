﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MasterProject.SharedKernel.Interface
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        List<string> IncludeStrings { get; }
    }
}
