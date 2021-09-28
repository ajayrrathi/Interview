using MasterProject.Core.Entities;
using MasterProject.SharedKernel.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
