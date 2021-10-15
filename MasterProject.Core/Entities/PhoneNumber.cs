using MasterProject.SharedKernel.Entities;
using MasterProject.SharedKernel.Interface;
using System.ComponentModel.DataAnnotations;

namespace MasterProject.Core.Entities
{
    public class PhoneNumber : BaseEntity, IAggregate
    {
        [DisplayFormat(DataFormatString = "{0:###-###-####}", ApplyFormatInEditMode = true)]
        public string Number { get; set; }
    }
}
