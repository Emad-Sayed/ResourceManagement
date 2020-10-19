using AutoMapper;
using Core.Domain.Entity.Resource;
using Core.Domain.UOW;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Resource;
using Core.Infrastructure.Service;
using Core.Infrastructure.Service.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
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
            UOW.Events.Add(new ResourceEvent
            {
                CreatedById = LoggedUser,
                Start = model.Start,
                End = model.End,
                Name = model.Name,
                Location = model.Location,
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

        public IResponse GetMyEvenets(int ResourceId)
        {
            var data = UOW.Events.Find(e => e.CreatedById == ResourceId);
            if (data.ToList().Count == 0)
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
