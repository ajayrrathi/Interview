using MasterProject.SharedKernel.Entities;
using MasterProject.SharedKernel.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterProject.Core.Entities
{
    public class Product : BaseEntity, IAggregate
    {

        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        public Guid ClientId { get; set; }

        [MaxLength(256, ErrorMessage = "Name should not be more that 256 charater.")]
        public string Name { get; set; }

        [MaxLength(256, ErrorMessage = "Description should not be more that 256 charater.")]
        public string Description { get; set; }

        public string ProductImageUri { get; set; }

        public string ValidSkus { get; set; }

        [InverseProperty("Product")]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<ProductAttribute> ProductAttributes { get; set; }

        [InverseProperty("CategoryProduct")]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<ProductCatergories> ProductCatergories { get; set; }


    }
}
