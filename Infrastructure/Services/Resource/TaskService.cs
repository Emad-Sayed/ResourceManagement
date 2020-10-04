using AutoMapper;
using Core.Domain.Entity.Resource;
using Core.Domain.UOW;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Resource;
using Core.Infrastructure.Service.Resource;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Services.Resource
{
    public class TaskService : ITaskService
    {
        public readonly IUOW UOW;
        public readonly IMapper mapper;
        public readonly IResponse response;
        public TaskService(IUOW uow_, IResponse response_, IMapper mapper_)
        {
            UOW = uow_;
            mapper = mapper_;
            response = response_;
        }

        public IResponse AdminApproveTask(List<int> taskIds)
        {
            foreach (var taskId in taskIds)
            {
                var selectedTask = UOW.Tasks.SingleOrDefault(t => t.Id == taskId && t.ApprovedByMe == true);
                if (selectedTask != null)
                {
                    selectedTask.ApprovedByAdmin = true;
                }
            }

            UOW.Compelete();
            return response;
        }

        public IResponse ApproveMyTask(List<int> taskIds, int resourseId)
        {
            foreach (var taskId in taskIds)
            {
                var selectedTask = UOW.Tasks.SingleOrDefault(t => t.ResourceId == resourseId && t.Id == taskId);
                if (selectedTask != null)
                {
                    selectedTask.ApprovedByMe = true;
                }
            }
            UOW.Compelete();
            return response;
        }

        public IResponse Create(TaskCreateModel model, int LoggedUser)
        {
            var selectedResource = UOW.Users.SingleOrDefault(r => r.Id == model.ResourceId);
            if (selectedResource == null)
            {
                response.status = false;
                return response;
            }
            var newTask = mapper.Map<ResourceTask>(model);
            newTask.CreatedById = LoggedUser;
            UOW.Tasks.Add(newTask);
            UOW.Compelete();
            return response;
        }

        public IResponse CreateConfirmation(TaskCreateModel model)
        {
            throw new NotImplementedException();
        }

        public IResponse Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IResponse GetAll(TaskSearchModel search)
        {
            var (result, totalRows) = UOW.Tasks.TasksFilter(search);
            response.pagesTotalRows = totalRows;
            float all_pages = (float)totalRows / search.pageSize;
            response.pagesTotalNumber = (int)Math.Ceiling(all_pages);
            response.pageSize = search.pageSize;
            response.pageNumber = search.pageNumber;
            response.data = result;
            return response;
        }

        public IResponse GetById(int id)
        {
            throw new NotImplementedException();
        }
    }

}
