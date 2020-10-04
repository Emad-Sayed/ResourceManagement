using Core.Domain.Entity.Resource;
using Core.Domain.ViewModel.Resource;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Repository.Resource
{
    public interface ITaskRepository : IRepository<ResourceTask>
    {
        (IEnumerable<TaskViewModel>, int) TasksFilter(TaskSearchModel search);
    }
}
