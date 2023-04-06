using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

using app.Data.Entity;

namespace app.Data.Seed
{
    internal class StatusSeed : IEntityTypeConfiguration<CaseStatus>
    {
        public void Configure(EntityTypeBuilder<CaseStatus> builder)
        {
            builder.HasData(
                new CaseStatus { Id = 1, Status = ClaimStatus.CREATED, CreateDate = DateTime.Now  },
                new CaseStatus { Id = 2, Status = ClaimStatus.REJECTED, CreateDate = DateTime.Now },
                new CaseStatus { Id = 3, Status = ClaimStatus.CLOSED, CreateDate = DateTime.Now },
                new CaseStatus { Id = 4, Status = ClaimStatus.ASSIGNED, CreateDate = DateTime.Now },
                new CaseStatus { Id = 5, Status = ClaimStatus.INVESTIGATING, CreateDate = DateTime.Now },
                new CaseStatus { Id = 6, Status = ClaimStatus.PENDING, CreateDate = DateTime.Now },
                new CaseStatus { Id = 7, Status = ClaimStatus.APPROVED, CreateDate = DateTime.Now }
            );
        }
    }
}
