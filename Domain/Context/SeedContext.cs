using Core.Domain.Entity.Access;
using Core.Domain.Entity.Lookups;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Context
{
    public static class SeedContext
    {
        public static void Seed(this ModelBuilder builder)
        {
            #region Access
            builder.Entity<IdentityRole<int>>().HasData(
            new IdentityRole<int>
            {
                Id = 1,
                Name = "SUPERADMIN",
                NormalizedName = "SUPERADMIN",
            },
            new IdentityRole<int>
            {
                Id = 2,
                Name = "ADMIN",
                NormalizedName = "ADMIN",
            },
            new IdentityRole<int>
            {
                Id = 3,
                Name = "RESOURCE",
                NormalizedName = "RESOURCE",
            });
            var hasher = new PasswordHasher<AppUser>();
            builder.Entity<AppUser>().HasData(
            new AppUser
            {
                Id = 1,
                UserName = "SUPER",
                Email = "super@super.com",
                NormalizedEmail = "super@super.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "superdemo"),
                SecurityStamp = string.Empty
            },
            new AppUser
            {
                Id = 2,
                UserName = "ADMIN",
                Email = "admin@admin.com",
                NormalizedEmail = "admin@admin.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "admindemo"),
                SecurityStamp = string.Empty
            },
            new AppUser
            {
                Id = 3,
                UserName = "RESOURCE",
                Email = "resource@resource.com",
                NormalizedEmail = "resource@resource.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "resourcedemo"),
                SecurityStamp = string.Empty
            });
            builder.Entity<IdentityUserRole<int>>().HasData(
            new IdentityUserRole<int>
            {
                RoleId = 1,
                UserId = 1
            },
            new IdentityUserRole<int>
            {
                RoleId = 2,
                UserId = 2
            },
            new IdentityUserRole<int>
            {
                RoleId = 3,
                UserId = 3
            });
            #endregion
            #region tasks
            builder.Entity<TaskType>().HasData(
            new TaskType
            {
                Id = 1,
                Name = "Task"
            },
            new TaskType
            {
                Id = 2,
                Name = "Training"
            });

            builder.Entity<Priority>().HasData(
            new Priority
            {
                Id = 1,
                Name = "Low"
            },
            new Priority
            {
                Id = 2,
                Name = "Medium"
            },
            new Priority
            {
                Id = 3,
                Name = "High"
            });
            #endregion
        }
    }
}
