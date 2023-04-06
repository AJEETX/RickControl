using app.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace app.Data.Configurations
{
    internal class CaseStatusConfiguration : IEntityTypeConfiguration<CaseStatus>
    {
        public void Configure(EntityTypeBuilder<CaseStatus> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Status).IsRequired().HasMaxLength(30);
            builder.ToTable("Case");
        }
    }
}
