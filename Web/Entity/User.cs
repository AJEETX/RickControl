namespace app.Data.Entity
{
    public class User : BaseEntity
    { 
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Organisation? Organisation { get; set; }
        public EmployeeType? EmployeeType { get; set; }

    }
    public enum EmployeeType
    {
        CLIENT,
        VENDOR
    }
}
