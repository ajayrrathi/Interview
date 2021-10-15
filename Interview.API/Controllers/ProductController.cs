using MasterProject.Core.Entities;
using MasterProject.SharedKernel.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Interview.API.Controllers
{
    [Route("Product")]
    [ApiController]
    public class ProductController : BaseEntityController<Product>
    {
        public ProductController(IRepository repository) : base(repository)
        {

        }
    }

}
