using app.Data.Entity;

namespace app.Model.Domain
{
    public class UserDTO : BaseDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Organisation? Organisation { get; set; }
        public EmployeeType? EmployeeType { get; set; }
    }
}
