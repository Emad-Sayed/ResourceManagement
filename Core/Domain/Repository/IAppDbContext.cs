using Core.Domain.Entity.Lookups;
using Core.Domain.Entity.Resource;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Repository
{
    public interface IAppDbContext
    {
        DbSet<Priority> Priorities { get; set; }
        DbSet<TaskState> TaskStates { get; set; }
        DbSet<TaskType> TaskTypes { get; set; }
        DbSet<ResourceTask> Tasks { get; set; }
        DbSet<Attendance> Attendances { get; set; }
    }
}
