using BLL.Services.Abstracts;
using BLL.Services.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.DependencyResolvers
{
    public static class ManagerServiceResolver 
    {
        public static void AddManagerServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IServiceManager<>), typeof(ServiceManager<>));
            services.AddScoped<IBranchService, BranchService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IScheduleService, ScheduleService>();
            services.AddScoped<IVehicleService, VehicleService>();
        }
    }
}
