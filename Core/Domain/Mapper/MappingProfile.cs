using AutoMapper;
using Core.Domain.Entity.Resource;
using Core.Domain.ViewModel.Resource;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region resources
            CreateMap<TaskCreateModel, ResourceTask>();
            CreateMap<ResourceTask, TaskViewModel>();
            #endregion        
        }
    }
}
