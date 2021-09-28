using MasterProject.Core.Entities;
using MasterProject.SharedKernel.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
