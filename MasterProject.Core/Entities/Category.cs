using MasterProject.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MasterProject.Core.Entities
{
    public class Category: MasterEntity
    {
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        public Guid ClientId { get; set; }

        [InverseProperty("Category")]
        public IList<ProductCatergories> ProductCatergories { get; set; }
    }
}
