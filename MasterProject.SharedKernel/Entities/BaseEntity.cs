using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MasterProject.SharedKernel.Entities
{
    public abstract class BaseEntity
    {
      
        public Guid Id { get; set; } 
        public Guid? CreatedById { get; set; }
        public Guid? UpdatedByID { get; set; }
        public DateTime? CreatedOn { get; set; }  
        public DateTime? UpdatedOn { get; set; }
    }
}
