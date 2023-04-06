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
                new CaseStatus { Id = 1, Status = Status.CREATED.ToString(), CreateDate = DateTime.Now  },
                new CaseStatus { Id = 2, Status = Status.REJECTED.ToString(), CreateDate = DateTime.Now },
                new CaseStatus { Id = 3, Status = Status.CLOSED.ToString(), CreateDate = DateTime.Now },
                new CaseStatus { Id = 4, Status = Status.ASSIGNED.ToString(), CreateDate = DateTime.Now },
                new CaseStatus { Id = 5, Status = Status.INVESTIGATING.ToString(), CreateDate = DateTime.Now },
                new CaseStatus { Id = 6, Status = Status.PENDING.ToString(), CreateDate = DateTime.Now },
                new CaseStatus { Id = 7, Status = Status.APPROVED.ToString(), CreateDate = DateTime.Now }
            );
        }
    }
}
