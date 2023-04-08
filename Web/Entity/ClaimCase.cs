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
}
