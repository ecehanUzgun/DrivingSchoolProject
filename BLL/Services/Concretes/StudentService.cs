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
    }
}
