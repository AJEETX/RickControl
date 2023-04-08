using System.Collections.Generic;

namespace app.Data.Entity
{
    public class Store : BaseEntity
    {
        public string StoreName { get; set; }
        public string StoreCode { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<StoreStock> StoreStock { get; set; }
    }
}
