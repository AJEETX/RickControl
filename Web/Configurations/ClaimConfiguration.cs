using app.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace app.Data.Configurations
{
    internal class ClaimConfiguration : IEntityTypeConfiguration<ClaimCase>
    {
        public void Configure(EntityTypeBuilder<ClaimCase> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);
            builder.ToTable("Case");
        }
    }
}
