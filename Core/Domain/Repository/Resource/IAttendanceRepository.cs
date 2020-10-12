using Core.Domain.Entity.Resource;
using Core.Domain.ViewModel.Resource;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Repository.Resource
{
    public interface IAttendanceRepository : IRepository<Attendance>
    {
        (IEnumerable<AttendanceViewModel>, int) AttendanceFilter(AttendanceSearchModel search);
        IEnumerable<AttendanceGroupViewModel> AttendanceMonthlyGroup(AttendanceSearchModel search);
    }
}

