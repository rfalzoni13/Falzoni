using Falzoni.Domain.Entities.Base;

namespace Falzoni.Domain.Entities.Registration
{
    public class ProductCategory : BaseEntity
    {
        public string Name { get; set; }


        public virtual Product Product { get; set; }
    }
}
