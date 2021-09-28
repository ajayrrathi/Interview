using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using MasterProject.SharedKernel.Interface;

namespace MasterProject.SharedKernel.Specification
{
    public abstract class BaseSpecification<T> : ISpecification<T>
    {
        public Expression<Func<T, bool>> Criteria { get; set; }

        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();

        public List<string> IncludeStrings { get; } = new List<string>();

        protected virtual void AddInclude(Expression<Func<T, object>> includeExpresion) {
            Includes.Add(includeExpresion);
        }
        protected virtual void AddInclude(string includeString)
        {
            IncludeStrings.Add(includeString);
        }
    }
}
