using MODEL.Entities;

namespace BLL.Services.Abstracts
{
    public interface IStudentService:IServiceManager<Student>
    {
        int GetRemaningLessonHours(int studentId);
        //Tüm öğrencilerin kalan ders haklarını raporlar
        IEnumerable<Student> GetStudentsWithRemainingHours();
    }
}
