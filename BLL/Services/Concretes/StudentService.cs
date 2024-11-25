using BLL.Services.Abstracts;
using DAL.Repository.Abstracts;
using MODEL.Entities;

namespace BLL.Services.Concretes
{
    public class StudentService : ServiceManager<Student>, IStudentService
    {
        public StudentService(IRepository<Student> repository) : base(repository)
        {
            
        }

        // Öğrencinin kalan ders hakkını getirir
        public int GetRemaningLessonHours(int studentId)
        {
            var student = GetById(studentId);
            return student?.CourseHours ?? 0; //Öğrenci yoksa 0 döner
        }

        //Öğrencilerin kalan ders haklarını raporlar
        public IEnumerable<Student> GetStudentsWithRemainingHours()
        {
            return GetAll().Where(s => s.CourseHours > 0).ToList(); //6 hakkı dolmayan öğrencileri filtrele
        }
    }
}
