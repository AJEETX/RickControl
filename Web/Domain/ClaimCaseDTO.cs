using app.Data.Entity;
using System;

namespace app.Domain
{
    public class ClaimCaseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CaseStatus KYCCaseStatus { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime? RecordCreatedOn { get; set; }
        public Organisation? Organisation { get; set; }
    }
}
