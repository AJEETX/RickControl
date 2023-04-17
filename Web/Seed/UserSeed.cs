using app.Common.Extensions;
using app.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace app.Data.Seed
{
    internal class UserSeed : IEntityTypeConfiguration<User>
    {
        string adminPassword = "12345";
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    Email = app.Common.Constants.ADMIN_EMAIL,
                    Name = "Portal",
                    Surname = "Admin",
                    Password = adminPassword.MD5Hash(),
                    CreateDate = DateTime.Now,
                    StoreId = 1,
                    EmployeeTypeId = 1,
                    // Roles = new List<Role>{new Role{ Id = 1}}
                },
                new User
                {
                    Id = 2,
                    Email = app.Common.Constants.CLIENT_ADMIN_EMAIL,
                    Name = "Client",
                    Surname = "Admin",
                    Password = adminPassword.MD5Hash(),
                    CreateDate = DateTime.Now,
                    StoreId = 1,
                    EmployeeTypeId = 1,
                },
                new User
                {
                    Id = 3,
                    Email = app.Common.Constants.CLIENT_CREATOR_EMAIL,
                    Name = "Client",
                    Surname = "Creator",
                    Password = adminPassword.MD5Hash(),
                    CreateDate = DateTime.Now,
                    StoreId = 1,
                    EmployeeTypeId = 1,
                },
                new User
                {
                    Id = 4,
                    Email = app.Common.Constants.CLIENT_ASSIGNER_EMAIL,
                    Name = "Client",
                    Surname = "Assigner",
                    Password = adminPassword.MD5Hash(),
                    CreateDate = DateTime.Now,
                    StoreId = 1,
                    EmployeeTypeId = 1,
                },
                new User
                {
                    Id = 5,
                    Email = app.Common.Constants.CLIENT_ASSESSOR_EMAIL,
                    Name = "Client",
                    Surname = "Assessor",
                    Password = adminPassword.MD5Hash(),
                    CreateDate = DateTime.Now,
                    StoreId = 1,
                    EmployeeTypeId = 1,
                },
                new User
                {
                    Id = 6,
                    Email = app.Common.Constants.AGENCY_ADMIN_EMAIL,
                    Name = "Agency",
                    Surname = "Admin",
                    Password = adminPassword.MD5Hash(),
                    CreateDate = DateTime.Now,
                    CategoryId = 1,
                    EmployeeTypeId = 1,
                },
                new User
                {
                    Id = 7,
                    Email = app.Common.Constants.AGENCY_SUPERVISOR_EMAIL,
                    Name = "Agency",
                    Surname = "Supervisor",
                    Password = adminPassword.MD5Hash(),
                    CreateDate = DateTime.Now,
                    EmployeeTypeId = 1,
                    CategoryId = 1
                },
                new User
                {
                    Id = 8,
                    Email = app.Common.Constants.AGENCY_AGENT_EMAIL,
                    Name = "Agency",
                    Surname = "Supervisor",
                    Password = adminPassword.MD5Hash(),
                    CreateDate = DateTime.Now,
                    EmployeeTypeId = 1,
                    CategoryId = 1
                }
            );
        }
    }
}
