using Core.Domain.ViewModel;
using Core.Infrastructure.Service.Resource;
using Core.Infrastructure.Service.Users;
using Infrastructure.Services.Resource;
using Infrastructure.Services.User;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DependencyInjection
{
    public static class InfrastructureDependencies
    {
        public static void InjectInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IResponse, Response>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ITaskService, TaskService>();
            services.AddTransient<IAttendanceService, AttendanceService>();
        }
    }
}