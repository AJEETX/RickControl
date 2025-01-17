﻿using app.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace app.Data.Seed
{
    internal class StoreSeed : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasData(new Store { Id = 1, StoreCode = "EX01", StoreName = "Example Company", CreateDate = DateTime.Now });
        }
    }
}
