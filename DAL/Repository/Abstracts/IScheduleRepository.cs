using MODEL.Entities;

namespace DAL.Repository.Abstracts
{
    public interface IScheduleRepository : IRepository<Schedule>
    {
        List<TimeSpan> GetBusyHours(int teacherId, DateTime date);
        List<TimeSpan> GetAvailableHours(int teacherId, DateTime date, List<TimeSpan> workingHours);
        bool IsHourAvailable(int teacherId, DateTime date, TimeSpan startTime);
    }
}
