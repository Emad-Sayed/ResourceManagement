using Core.Domain.Entity.Access;
using Core.Domain.Entity.Lookups;
using Core.Domain.Entity.Resource;
using Core.Domain.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Context
{
    public class AppDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int>, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();
        }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<TaskState> TaskStates { get; set; }
        public DbSet<ResourceTask> Tasks { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

    }
}
