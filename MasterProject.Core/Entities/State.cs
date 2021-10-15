using MasterProject.SharedKernel.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace MasterProject.Core.Entities
{
    public class State : MasterEntity
    {
        public Guid CountryID { get; set; }

        [ForeignKey("CountryID")]

        public Country Country { get; set; }
    }
}
