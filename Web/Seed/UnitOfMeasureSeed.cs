using app.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace app.Data.Seed
{
    internal class UnitOfMeasureSeed : IEntityTypeConfiguration<UnitOfMeasure>
    {
        public void Configure(EntityTypeBuilder<UnitOfMeasure> builder)
        {
            builder.HasData(new UnitOfMeasure { Id = 1, UnitOfMeasureName = "Comprehensive", Isocode = "Comprehensive", CreateDate = DateTime.Now });
            builder.HasData(new UnitOfMeasure { Id = 2, UnitOfMeasureName = "Non-Comprehensive", Isocode = "Non-Comprehensive", CreateDate = DateTime.Now });
            builder.HasData(new UnitOfMeasure { Id = 3, UnitOfMeasureName = "Other", Isocode = "Other", CreateDate = DateTime.Now });
        }
    }
}
