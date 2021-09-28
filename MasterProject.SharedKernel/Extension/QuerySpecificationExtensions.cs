using MasterProject.SharedKernel.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterProject.SharedKernel.Extension
{
    public static class QuerySpecificationExtensions
    {
        public static IQueryable<T> Specify<T>(this IQueryable<T> query, ISpecification<T> specification) where T : class
        {
            var quearyableResultWithIncludes = specification.Includes.Aggregate(query,
                                (current, include) => current.Include(include));

            var SecondaryResult = specification.IncludeStrings.Aggregate(quearyableResultWithIncludes,
                                (current, include) => current.Include(include));

            return SecondaryResult.Where(specification.Criteria);
        }
    }
}
