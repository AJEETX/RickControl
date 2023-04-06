using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using TS.EasyStockManager.Data.Entity;

namespace app.Entity
{
    public class ClaimCase : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        public KYCCaseStatus KYCCaseStatus { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime? RecordCreatedOn { get; set; }
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
