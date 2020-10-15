using Core.Domain.Entity.Resource;
using Core.Domain.Repository.Resource;
using Core.Domain.ViewModel.Resource;
using Domain.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace Domain.Repository.Resource
{
    public class TaskRepository : Repository<ResourceTask>, ITaskRepository
    {
        public TaskRepository(AppDbContext _Context) : base(_Context)
        {
        }

        public (IEnumerable<TaskViewModel>, int) TasksFilter(TaskSearchModel search)
        {
            var query = Context.Tasks.Include(t => t.Type).Where(t =>
                (String.IsNullOrEmpty(search.keyWord) || t.Name.Contains(search.keyWord) || t.Description.Contains(search.keyWord)) &&
                (search.TasksIds == null || search.TasksIds.Count == 0 || search.TasksIds.Contains(t.Id)) &&
                (search.TypeIds == null || search.TypeIds.Count == 0 || search.TypeIds.Contains(t.TypeId)) &&
                (search.ResourcesIds == null || search.ResourcesIds.Count == 0 || search.ResourcesIds.Contains(t.ResourceId)) &&
                (search.StateIds == null || search.StateIds.Count == 0 || search.StateIds.Contains(t.TaskStateId)) &&
                (search.SpecificDate == null || (t.StartDate.Value.Date <= search.SpecificDate.Value.Date && search.SpecificDate.Value.Date < t.EndDate.Value.Date)) &&
                (search.StartDate == null || t.StartDate.Value > search.StartDate) &&
                (search.EndDate == null || t.EndDate.Value < search.EndDate))
                .Select(t => new TaskViewModel
                {
                    TaskId = t.Id,
                    Name = t.Name,
                    Description = t.Description,
                    ResourceId = t.ResourceId,
                    ResourceName = t.Resource.UserName,
                    ApprovedByResource = t.ApprovedByMe,
                    StartDate = t.StartDate.Value,
                    EndDate = t.EndDate.Value,
                    TypeId = t.TypeId,
                    TypeName = t.Type.Name,
                    PrioityId = t.PriorityId,
                    PrioityName = t.Priority.Name,
                    TaskStateId = t.TaskStateId,
                    TaskStateName = t.TaskState.Name,
                    Comment = t.Comment,
                });
            var count = query.Count();
            var data = query.OrderBy(t => t.TaskId).Skip((search.pageNumber - 1) * search.pageSize).Take(search.pageSize);
            return (data, count);
        }
        public IEnumerable<TaskGroupViewModel> TasksMonthlyGroup(TaskSearchModel search)
        {
            var query = Context.Tasks.Include(t => t.Type).Where(t =>
                (String.IsNullOrEmpty(search.keyWord) || t.Name.Contains(search.keyWord) || t.Description.Contains(search.keyWord)) &&
                (search.TasksIds == null || search.TasksIds.Count == 0 || search.TasksIds.Contains(t.Id)) &&
                (search.TypeIds == null || search.TypeIds.Count == 0 || search.TypeIds.Contains(t.TypeId)) &&
                (search.ResourcesIds == null || search.ResourcesIds.Count == 0 || search.ResourcesIds.Contains(t.ResourceId)) &&
                (search.StateIds == null || search.StateIds.Count == 0 || search.StateIds.Contains(t.TaskStateId)) &&
                (search.SpecificDate == null || (t.StartDate.Value.Date <= search.SpecificDate.Value.Date && search.SpecificDate.Value.Date < t.EndDate.Value.Date)) &&
                (search.StartDate == null || t.StartDate.Value > search.StartDate) &&
                (search.EndDate == null || t.EndDate.Value < search.EndDate))
                .Select(t => new TaskViewModel
                {
                    TaskId = t.Id,
                    Name = t.Name,
                    Description = t.Description,
                    ResourceId = t.ResourceId,
                    ResourceName = t.Resource.UserName,
                    ApprovedByResource = t.ApprovedByMe,
                    StartDate = t.StartDate.Value,
                    EndDate = t.EndDate.Value,
                    TypeId = t.TypeId,
                    TypeName = t.Type.Name,
                    PrioityId = t.PriorityId,
                    PrioityName = t.Priority.Name,
                    TaskStateId = t.TaskStateId,
                    TaskStateName = t.TaskState.Name,
                    Comment = t.Comment,
                });
            var dataGroupped = query.ToList().GroupBy(g => new { g.StartDate.Year,g.StartDate.Month }).Select(s => new TaskGroupViewModel
            {
                Start = s.First().StartDate.Date,
                Month = s.First().StartDate.Month,
                Year = s.First().StartDate.Year,
                TotalTasks = s.Count(),
                Pending = s.Count(wh => wh.TaskStateId == 1),
                Rejected = s.Count(wh => wh.TaskStateId == 2),
                Approved = s.Count(wh => wh.TaskStateId == 3),
            }).OrderBy(or => or.Year).ThenBy(or => or.Month);
            return dataGroupped;
        }
    }
}
