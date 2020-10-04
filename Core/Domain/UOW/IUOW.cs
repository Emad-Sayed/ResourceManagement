using Core.Domain.Repository;
using Core.Domain.Repository.Resource;
using Core.Domain.Repository.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.UOW
{
    public interface IUOW
    {
        IUserRepository Users { get; }
        ITaskRepository Tasks { get; }
        IAttendanceRepository Attendances { get; }
        int Compelete();
    }
}

