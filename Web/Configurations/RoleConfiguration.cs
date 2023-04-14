using app.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace app.Data.Configurations
{
    internal class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Code).IsRequired().HasMaxLength(3);
            builder.ToTable("Role");
        }
    }
}
