using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterProject.SharedKernel.Entities;
using MasterProject.SharedKernel.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Interview.API.Interfaces
{
    public interface IBaseEntity<T> where T: BaseEntity, IAggregate
    {
        public Task<ActionResult<T>> Create(T Item);
        public Task<ActionResult<T>> Delete(Guid Id);

        public Task<ActionResult> Get();

        public Task<ActionResult<T>> Get(Guid Id);

        public Task<ActionResult> Update(T Item);
    }
}
