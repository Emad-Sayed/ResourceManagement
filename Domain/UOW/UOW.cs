using Core.Domain.Entity.Resource;
using Core.Domain.Repository;
using Core.Domain.Repository.Resource;
using Core.Domain.Repository.User;
using Core.Domain.UOW;
using Domain.Context;
using Domain.Repository;
using Domain.Repository.Resource;
using Domain.Repository.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class UOW : IUOW
    {
        AppDbContext context;
        public UOW(AppDbContext _context)
        {
            context = _context;
            Users = new UserRepository(_context);
            Tasks = new TaskRepository(_context);
            Attendances = new AttendanceRepository(_context);
            Events = new Repository<ResourceEvent>(_context);
        }
        public IUserRepository Users { get; }
        public ITaskRepository Tasks { get; }
        public IAttendanceRepository Attendances { get; }
        public IRepository<ResourceEvent> Events { get; }
        public int Compelete()
        {
            return context.SaveChanges();
        }

    }
}
