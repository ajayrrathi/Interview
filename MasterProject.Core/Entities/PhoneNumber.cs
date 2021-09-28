using MasterProject.SharedKernel.Entities;
using MasterProject.SharedKernel.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MasterProject.Core.Entities
{
    public class PhoneNumber: BaseEntity, IAggregate
    {
        [DisplayFormat(DataFormatString = "{0:###-###-####}", ApplyFormatInEditMode = true)]
        public string Number { get; set; }
    }
}
