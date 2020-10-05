using AutoMapper;
using Core.Domain.Entity.Resource;
using Core.Domain.UOW;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Resource;
using Core.Infrastructure.Service;
using Core.Infrastructure.Service.Resource;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Services.Resource
{
    public class EvnetService : IEventService
    {
        public readonly IUOW UOW;
        public readonly IMapper mapper;
        public readonly IResponse response;
        public EvnetService(IUOW uow_, IResponse response_, IMapper mapper_)
        {
            UOW = uow_;
            mapper = mapper_;
            response = response_;
        }

        public IResponse Create(EventCreateModel model, int LoggedUser)
        {
            var StartTime = TimeSpan.Parse(model.Start);
            var EndTime = TimeSpan.Parse(model.End);
            UOW.Events.Add(new ResourceEvent
            {
                CreatedById = LoggedUser,
                Day = model.Day,
                Name = model.Name,
                Location = model.Location,
                From = StartTime,
                End = EndTime
            });
            UOW.Compelete();
            return response;
        }

        public IResponse Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IResponse GetAll(BaseSearch search)
        {
            throw new NotImplementedException();
        }

        public IResponse GetByDate(DateTime date, int VisitorId)
        {
            var data = UOW.Events.SingleOrDefault(e => e.Day.Date == date.Date);
            if (data == null)
                response.status = false;
            else
                response.data = data;
            return response;
        }

        public IResponse GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
