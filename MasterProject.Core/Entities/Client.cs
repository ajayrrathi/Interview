using MasterProject.SharedKernel.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using MasterProject.SharedKernel.Interface;

namespace MasterProject.Core.Entities
{
    public class Client : BaseEntity, IAggregate
    {
        public string Name { get; set; }

        
        public Guid? AddressID { get; set; }
        [ForeignKey("AddressID")]
        public Address Address { get; set; }
         

        [InverseProperty("Client")]
        public IList<Product> Products { get; set; }

        [InverseProperty("Client")]
        public IList<Attribute> Attributes { get; set; }

        [InverseProperty("Client")]
        public IList<Category> Categories { get; set; }

    }
}
