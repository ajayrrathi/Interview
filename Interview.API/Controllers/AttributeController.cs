using entity = MasterProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterProject.SharedKernel.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Interview.API.Controllers
{
    [Route("Attribute")]
    [ApiController]
    public class AttributeController : BaseEntityController<entity.Attribute>
    {
        public AttributeController(IRepository repository) : base(repository)
        {

        }
    }
     
}
