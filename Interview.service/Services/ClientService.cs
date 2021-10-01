using MasterProject.service.Interface;
using Interview.service.Services;
using MasterProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MasterProject.service.Services
{
    public class ClientService : BaseEntityService<Client>, IClient
    {
        public ClientService(HttpClient httpClient) : base(httpClient, "Client")
        {

        }
    }
}
