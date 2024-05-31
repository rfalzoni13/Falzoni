using Falzoni.Presentation.Administrator.Models.Base;

namespace Falzoni.Presentation.Administrator.Models.Registration
{
    public class ProductCategoryModel : BaseModel
    {
        public string Name { get; set; }

        public virtual ProductModel Product { get; set; }
    }
}