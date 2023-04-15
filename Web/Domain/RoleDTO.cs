namespace app.Model.Domain
{
    public class RoleDTO : BaseDTO
    {
        public int? UserId {get;set;}
        public string RoleName { get; set; }
        public string RoleCode { get; set; }
    }
}
