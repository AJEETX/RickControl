using app.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace app.Data.Seed
{
    internal class RoleSeed : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role { Id = 1, Name = "portal-admin", Code = app.Common.Constants.ADMIN_ROLE, CreateDate = DateTime.Now },
                new Role { Id = 2, Name = "client-admin", Code = app.Common.Constants.CLIENT_ADMIN_ROLE, CreateDate = DateTime.Now },
                new Role { Id = 3, Name = "client-creator", Code = app.Common.Constants.CLIENT_CREATOR_ROLE, CreateDate = DateTime.Now },
                new Role { Id = 4, Name = "client-assigner", Code = app.Common.Constants.CLIENT_ASSIGNER_ROLE, CreateDate = DateTime.Now },
                new Role { Id = 5, Name = "client-assessor", Code = app.Common.Constants.CLIENT_ASSESSOR_ROLE, CreateDate = DateTime.Now },
                new Role { Id = 6, Name = "agency-admin", Code = app.Common.Constants.AGENCY_ADMIN_ROLE, CreateDate = DateTime.Now },
                new Role { Id = 7, Name = "agency-supervisor", Code = app.Common.Constants.AGENCY_SUPERVISOR_ROLE, CreateDate = DateTime.Now },
                new Role { Id = 8, Name = "agency-agent", Code = app.Common.Constants.AGENCY_AGENT_ROLE, CreateDate = DateTime.Now }
                );
        }
    }
}
