using MasterProject.SharedKernel.Entities;
using MasterProject.SharedKernel.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MasterProject.Core.Entities
 {
    /// <summary>
    /// Class handle Many to Many relation ship between Product and Attribute
    /// </summary>
    public class ProductAttribute : BaseEntity, IAggregate
    {
        #region Relationship properties
        public Guid ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public Guid AttributeId { get; set; }

        [ForeignKey("AttributeId")]
        public Attribute Attribute {get; set;}

        #endregion Relationship properties
    }
}
