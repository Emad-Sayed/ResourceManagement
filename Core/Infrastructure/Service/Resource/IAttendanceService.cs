using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Resource;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.Service.Resource
{
    public interface IAttendanceService 
    {
        IResponse StartWork(int resourceId);
        IResponse EndWork(AttendanceEndWork attendance,int resourceId);
        IResponse GetToDayAttendance(int resourceId);
        IResponse GetAll(AttendanceSearchModel search);
        IResponse GetGrouped(AttendanceSearchModel search);
        IResponse GetAdminApprove(List<int> ids);
        IResponse GetAdminReject(List<int> ids);
        IResponse GetAdminExceptionApprove(int id);
    }
}

