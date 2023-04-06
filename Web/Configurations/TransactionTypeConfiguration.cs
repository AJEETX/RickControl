using app.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace app.Data.Configurations
{
    internal class TransactionTypeConfiguration : IEntityTypeConfiguration<TransactionType>
    {
        public void Configure(EntityTypeBuilder<TransactionType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TransactionTypeName).IsRequired().HasMaxLength(50);
            builder.ToTable("TransactionType");
        }
    }
}
