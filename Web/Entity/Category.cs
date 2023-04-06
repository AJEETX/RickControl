using System.Collections.Generic;

namespace app.Data.Entity
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
