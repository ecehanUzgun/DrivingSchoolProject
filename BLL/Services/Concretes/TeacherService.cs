using BLL.Services.Abstracts;
using DAL.Repository.Abstracts;
using MODEL.Entities;

namespace BLL.Services.Concretes
{
    public class TeacherService : ServiceManager<Teacher>, ITeacherService
    {
        public TeacherService(IRepository<Teacher> repository) : base(repository)
        {
        }
    }
}
