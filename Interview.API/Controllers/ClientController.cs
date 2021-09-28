using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterProject.Core.Entities;
using MasterProject.SharedKernel.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Interview.API.Controllers
{
    [Route("Client")]
    [ApiController]
    public class ClientController  : BaseEntityController<Client>
    {
        public ClientController(IRepository repository)  : base (repository) 
        { 
        
        }
    }
}