using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interview.API.Interfaces;
using MasterProject.SharedKernel.Entities;
using MasterProject.SharedKernel.Interface;
using MasterProject.SharedKernel.Specification;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Interview.API.Controllers
{
     
    public class BaseEntityController<T> : ControllerBase, IBaseEntity<T> where T: BaseEntity, IAggregate
    {
        protected IRepository Repository;
        public BaseEntityController(IRepository repository)
        {
            Repository = repository;
        }
        [HttpPost()]
        public virtual async Task<ActionResult<T>> Create(T Item)
        {
            try
            {
                if (Item == null) return BadRequest();

                await Repository.AddAsync<T>(Item).ConfigureAwait(false);

                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error while adding record.");
            }
        }
        [HttpDelete("{Id:Guid}")]
        public virtual async Task<ActionResult<T>> Delete(Guid Id)
        {
            try {

                var ToDelete = (await Repository.ListAsync<T>(new BaseEntityByIdSpecification<T>(Id))).FirstOrDefault<T>();
                if (ToDelete == null)
                {
                    return NotFound($"ID {Id} not found.");
                }
                await Repository.DeleteAsync<T>(ToDelete);
                return ToDelete;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error while deleting record.");
            }
        }

        [HttpGet()]
        public virtual async Task<ActionResult> Get()
        {
             try
            {
                return Ok(await Repository.ListAsync<T>());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error while retriving record.");
            }
        }

        [HttpGet("{Id:Guid}")]
        public virtual async Task<ActionResult<T>> Get(Guid Id)
        {
            try
            {
                T result = (await Repository.ListAsync<T>(new BaseEntityByIdSpecification<T>(Id))).FirstOrDefault<T>();

                if (result == null) return NotFound();

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error while deleting record.");
            }
        }

        [HttpPut()]
        public virtual async Task<ActionResult> Update(T Item)
        {
            try {
                if (Item == null || !ModelState.IsValid) return BadRequest();

                await Repository.UpdateAsync<T>(Item).ConfigureAwait(false);

                return StatusCode(StatusCodes.Status200OK);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error while updating record.");
            }
        }
    }
}