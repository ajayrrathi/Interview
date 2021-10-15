using MasterProject.SharedKernel.Entities;
using MasterProject.SharedKernel.Interface;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterProject.Core.Entities
{
    /// <summary>
    ///  Class handle Many to Many relation ship between Product and Categories
    /// </summary>

    public class ProductCatergories : BaseEntity, IAggregate
    {
        #region Relationship properties
        public Guid ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product CategoryProduct { get; set; }

        public Guid CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        #endregion Relationship properties
    }
}
