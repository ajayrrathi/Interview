using MasterProject.Core.Entities;
using MasterProject.SharedKernel.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Interview.API.Controllers
{
    [Route("Client")]
    [ApiController]
    public class ClientController : BaseEntityController<Client>
    {
        public ClientController(IRepository repository) : base(repository)
        {

        }
    }
}