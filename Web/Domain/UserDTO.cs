using System.Collections.Generic;
using app.Data.Entity;

namespace app.Model.Domain
{
    public class UserDTO : BaseDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? StoreName { get; set; } = string.Empty;
        public int? StoreId { get; set; }
        public string? CategoryName { get; set; }
        public int? CategoryId { get; set; }        
        public int? EmployeeTypeId { get; set; } 
        public string EmployeeType { get; set; }
        public IList<string> SelectedRoles { get; set; }
        public IList<RoleDTO> Roles { get; set; }
    }
}
