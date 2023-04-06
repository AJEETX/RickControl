using System.ComponentModel.DataAnnotations;

namespace app.Data.Entity
{
 
    public class CaseStatus : BaseEntity
    {

        public string Status { get; set; }
 
    }
    public enum Status
    {
        CREATED,
        ASSIGNED,
        CLOSED,
        PENDING,
        INVESTIGATING,
        REJECTED,
        APPROVED
    }
    public class Organisation : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
