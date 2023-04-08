namespace app.Data.Entity
{
    public class User : BaseEntity
    { 
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Active { get; set; }
        public int? StoreId { get; set; } = default!;
        public virtual Store Store { get; set; }
        public int? EmployeeTypeId { get; set; } = default!;
        public virtual EmployeeType EmployeeType { get; set; }

    }
    public class EmployeeType : BaseEntity
    {
        public string Name { get; set; }
    }
}
