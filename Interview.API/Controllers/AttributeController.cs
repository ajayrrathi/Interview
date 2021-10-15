using MasterProject.SharedKernel.Interface;
using Microsoft.AspNetCore.Mvc;
using entity = MasterProject.Core.Entities;

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
