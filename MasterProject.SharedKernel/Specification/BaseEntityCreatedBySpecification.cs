﻿using System;

namespace MasterProject.SharedKernel.Specification
{
    public class BaseEntityCreatedBySpecification<T> : BaseSpecification<T> where T : MasterProject.SharedKernel.Entities.BaseEntity
    {
        public BaseEntityCreatedBySpecification(Guid id)
        {
            Criteria = Item => Item.CreatedById == id;
        }
    }
}
