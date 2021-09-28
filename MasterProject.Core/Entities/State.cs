using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using MasterProject.SharedKernel.Entities;
namespace MasterProject.Core.Entities
{
   public  class State : MasterEntity
    {
        public Guid CountryID { get; set; }

        [ForeignKey("CountryID")]

        public Country Country { get; set; }
    }
}
