using MasterProject.Core.Entities;
using MasterProject.SharedKernel.Entities;
using MasterProject.SharedKernel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Interview.Web.Data.Interface
{
    public interface IBaseEntity<T> where T : BaseEntity, IAggregate
    {
        Task<IEnumerable<T>> GetAll();
        Task<HttpResponseMessage> Create(T Entity);

        Task<T> Get(Guid Id);

        Task<HttpResponseMessage> Update(T Entity);

    }
}
