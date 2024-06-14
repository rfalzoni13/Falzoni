using Falzoni.Presentation.Administrator.Models.Base;
using Falzoni.Presentation.Administrator.Models.Stock;

namespace Falzoni.Presentation.Administrator.Models.Register
{
    public class ProductCategoryModel : BaseModel
    {
        public string Name { get; set; }

        public virtual ProductModel Product { get; set; }
    }
}