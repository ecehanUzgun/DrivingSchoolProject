using MODEL.Entities;
using MODEL.Enums;

namespace BLL.Services.Abstracts
{
    public interface IScheduleService:IServiceManager<Schedule>
    {
        // Tüm ders programlarını getirir
        IEnumerable<Schedule> GetAllSchedules();

        // Belirli bir öğretmenin belirli bir tarihteki derslerini getir
        IEnumerable<Schedule> GetSchedulesByTeacher(int teacherId, DateTime date);

        // Belirli bir öğrencinin programını getir
        IEnumerable<Schedule> GetSchedulesByStudent(int studentId);

        // Dersin durumunu güncelle
        Task UpdateLessonStatus(int scheduleId, DataStatus status);

        Task<bool> AddLessonAsync(int teacherId, int studentId, DateTime date, TimeSpan startTime); 

        Task<List<Schedule>> GetAllSchedulesWithDetailAsync();
    }
}
