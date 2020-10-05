using Core.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.Service
{
    public interface IService<Search, CreateModel>
    {
        IResponse GetAll(Search search);
        IResponse GetById(int id);
        IResponse Create(CreateModel model, int LoggedUser);
        IResponse Delete(int id);
    }
}