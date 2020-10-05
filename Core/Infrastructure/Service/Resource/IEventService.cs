using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Resource;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.Service.Resource
{
    public interface IEventService : IService<BaseSearch,EventCreateModel>
    {
        IResponse GetByDate(DateTime date,int VisitorId);
    }
}
