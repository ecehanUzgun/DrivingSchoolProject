using MODEL.Entities;

namespace DAL.Repository.Abstracts
{
    public interface IScheduleRepository : IRepository<Schedule>
    {
        List<TimeSpan> GetBusyHours(int teacherId, DateTime date); //Programlanmış saatler
        List<TimeSpan> GetAvailableHours(int teacherId, DateTime date, List<TimeSpan> workingHours); //Boş saatler
        bool IsHourAvailable(int teacherId, DateTime date, TimeSpan startTime); //Programdaki uygunluğu kontrol et
    }   
}
