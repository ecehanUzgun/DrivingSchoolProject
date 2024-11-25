using MODEL.Entities;

namespace BLL.Services.Abstracts
{
    public interface ITeacherService:IServiceManager<Teacher>
    {
        //Öğretmenlerin listesini döner
        Task<List<Teacher>> GetAllTeachersAsync();

        //Seçilen öğretmenin müsait olduğu tarihleri getirir
        Task<List<DateTime>> GetAvailableDatesAsync(int teacherId);

        //Seçilen tarihe göre boş saatleri getirir.
        Task<List<TimeSpan>> GetAvailableHoursAsync(int teacherId, DateTime date);

        //Ders programına kayıt işlemi
        //Task<bool> AddLessonAsync(int teacherId, int studentId, DateTime date, TimeSpan startTime);

        //Belirli bir öğretmen için ders programını kontrol eder
        Task<bool> IsTimeAvailableAsync(int teacherId, DateTime date, TimeSpan startTime);
    }
}
