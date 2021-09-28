using Interview.Web.Data.Interface;
using MasterProject.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Interview.Web.Data.Service
{
    public class ClientService : BaseEntityService<Client>, IClient
    {
        public ClientService(HttpClient httpClient) : base(httpClient, "Client")
        { 
        
        }
    }
}
