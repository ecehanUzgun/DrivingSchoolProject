using DAL.Context;
using DAL.Repository.Abstracts;
using MODEL.Entities;

namespace DAL.Repository.Concretes
{
    public class ScheduleRepository : Repository<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(ProjectContext context) : base(context)
        {
        }

        public List<TimeSpan> GetAvailableHours(int teacherId, DateTime date, List<TimeSpan> workingHours)
        {
            throw new NotImplementedException();
        }

        public List<TimeSpan> GetBusyHours(int teacherId, DateTime date)
        {
            throw new NotImplementedException();
        }

        public bool IsHourAvailable(int teacherId, DateTime date, TimeSpan startTime)
        {
            throw new NotImplementedException();
        }
    }
}
