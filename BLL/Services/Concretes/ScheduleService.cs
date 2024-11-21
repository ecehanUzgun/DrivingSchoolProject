using BLL.Services.Abstracts;
using DAL.Repository.Abstracts;
using MODEL.Entities;

namespace BLL.Services.Concretes
{
    public class ScheduleService : ServiceManager<Schedule>, IScheduleService
    {
        public ScheduleService(IRepository<Schedule> repository) : base(repository)
        {

        }
    }
}
