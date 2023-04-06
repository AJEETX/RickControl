using System.ComponentModel.DataAnnotations;

namespace app.Data.Entity
{
    public class ClaimCase : BaseEntity
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        public KYCCaseStatus KYCCaseStatus { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public bool Active { get; set; }
        public Organisation? Organisation { get; set; }

    }

    public enum KYCCaseStatus
    {
        CREATED,
        ASSIGNED,
        CLOSED,
        PENDING,
        INVESTIGATING
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
