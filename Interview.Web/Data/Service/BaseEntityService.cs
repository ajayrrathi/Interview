using MasterProject.Core.Entities;
using MasterProject.SharedKernel.Entities;
using MasterProject.SharedKernel.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Interview.Web.Data.Service
{
    public class BaseEntityService<T> : ControllerBase, Interview.Web.Data.Interface.IBaseEntity<T> where T : BaseEntity, IAggregate
    {
        private readonly HttpClient _httpClient;
        private readonly string _APIPath;
        public BaseEntityService(HttpClient httpClient, string APIPath)
        {
            this._httpClient = httpClient;
            this._APIPath = APIPath;
        }

        public virtual async Task<HttpResponseMessage> Create(T Entity)
        {
            return await _httpClient.PostAsJsonAsync<T>(_APIPath, Entity).ConfigureAwait(false);
        }

        public virtual async Task<T> Get(Guid Id)
        {
            return await _httpClient.GetFromJsonAsync<T>((_APIPath.EndsWith("/") ? _APIPath : _APIPath + "/") + System.Web.HttpUtility.UrlEncode(Id.ToString()));             
        }

        public virtual  async Task<IEnumerable<T>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<T[]>(_APIPath);
        }

        public virtual async Task<HttpResponseMessage> Update(T Entity)
        {
            return await _httpClient.PutAsJsonAsync<T>(_APIPath, Entity).ConfigureAwait(false);
        }
    }
}
