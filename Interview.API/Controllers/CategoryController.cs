using MasterProject.Core.Entities;
using MasterProject.SharedKernel.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Interview.API.Controllers
{
    [Route("Category")]
    [ApiController]
    public class CategoryController : BaseEntityController<Category>
    {
        public CategoryController(IRepository repository) : base(repository)
        {

        }
    }

}
