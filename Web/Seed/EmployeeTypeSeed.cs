using app.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace app.Data.Seed
{
    internal class EmployeeTypeSeed : IEntityTypeConfiguration<EmployeeType>
    {
        public void Configure(EntityTypeBuilder<EmployeeType> builder)
        {
            builder.HasData(
                new EmployeeType { Id = 1, Name = "Permanent", CreateDate = DateTime.Now },
                new EmployeeType { Id = 2, Name = "Contract" ,  CreateDate = DateTime.Now}
                );
        }
    }
}
