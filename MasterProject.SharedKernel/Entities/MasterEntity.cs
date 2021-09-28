using MasterProject.SharedKernel.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MasterProject.SharedKernel.Entities
{
    public class MasterEntity : BaseEntity, IAggregate
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public bool Deleted { get; set; } = false;
        //public DateTime? createdOn { get; set; }
        //[Required]
        //public new DateTime? CreatedOn
        //{
        //    get
        //    {
        //        return base.CreatedOn;
        //    }

        //    set {
        //        base.CreatedOn = value;
        //    }
        //}
        
    }
}
