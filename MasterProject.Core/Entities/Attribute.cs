using MasterProject.SharedKernel.Entities;
using MasterProject.SharedKernel.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MasterProject.Core.Entities
{
    public class Attribute : MasterEntity, IAggregate
    {
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        public Guid ClientId { get; set; }

       

    }
}
