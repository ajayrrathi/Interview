using System;
using System.Collections.Generic;
using System.Text;
using MasterProject.SharedKernel.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design.Serialization;
using System.Text.Json.Serialization;

namespace MasterProject.Core.Entities

{
    public class Country : MasterEntity
    {

        [InverseProperty("Country")]
        public IList<State> States { get; set; }

    }
}
