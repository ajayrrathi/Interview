using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MasterProject.SharedKernel.Extension
{
    public static class Queryable
    {
        public static IQueryable IncludeMultiple<T>(this IQueryable<T> query, params Expression<Func<T, object>>[] Includes) where T: class
        {
            if (Includes != null)
            {
                query = Includes.Aggregate(query,
                    (current, include) => current.Include(include));
            }
            return query;
        }
    }
}
