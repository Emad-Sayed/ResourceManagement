using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Resource;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.Service.Resource
{
    public interface ITaskService : IService<TaskSearchModel, TaskCreateModel>
    {
        IResponse ApproveMyTask(List<int> taskIds, int resourseId);
        IResponse AdminApproveTask(List<int> taskIds);
        IResponse AdminRejectTask(TaskRejectionModel reject);
        IResponse AdminReasignTask(AdminReasignTaskModel reasign);
        IResponse GetGrouped(TaskSearchModel search);
    }
}