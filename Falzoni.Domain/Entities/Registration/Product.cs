using Falzoni.Domain.Entities.Base;
using System;

namespace Falzoni.Domain.Entities.Registration
{
    public class Product : BaseEntity
    {
        public Guid ProductCategoryId { get; set; }

        public string Name { get; set; }

        public float Code { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }


        public virtual ProductCategory Category { get; set; }
    }
}
