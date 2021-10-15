using MasterProject.SharedKernel.Entities;
using MasterProject.SharedKernel.Interface;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterProject.Core.Entities
{
    public class Address : BaseEntity, IAggregate
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        public string City { get; set; }


        public string ZipCode { get; set; }

        #region Relationship properties

        public Guid StateID { get; set; }

        [ForeignKey("StateID")]
        public State State { get; set; }

        #endregion Relationship properties

    }
}
