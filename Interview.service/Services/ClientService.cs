using Interview.service.Services;
using MasterProject.Core.Entities;
using MasterProject.service.Interface;
using System.Net.Http;

namespace MasterProject.service.Services
{
    public class ClientService : BaseEntityService<Client>, IClient
    {
        public ClientService(HttpClient httpClient) : base(httpClient, "Client")
        {

        }
    }
}
