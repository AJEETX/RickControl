
using System.Collections.Generic;

namespace app.Data.Entity
{
    public class User : BaseEntity
    { 
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
        public bool Active { get; set; }
        public int? StoreId { get; set; } = default!;
        public virtual Store Store { get; set; }
        public int? CategoryId { get; set; } = default!;
        public virtual Category Category { get; set; }        
        public int? EmployeeTypeId { get; set; } = default!;
        public virtual EmployeeType EmployeeType { get; set; }
        public virtual ICollection<Role>  Roles  { get; set; } 
        public User()
        {
            this.Roles = new HashSet<Role>();
        }
    }
    public class EmployeeType : BaseEntity
    {
        public string Name { get; set; }
    }
}
