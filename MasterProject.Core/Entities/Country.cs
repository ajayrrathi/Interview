using MasterProject.SharedKernel.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterProject.Core.Entities

{
    public class Country : MasterEntity
    {

        [InverseProperty("Country")]
        public IList<State> States { get; set; }

    }
}
