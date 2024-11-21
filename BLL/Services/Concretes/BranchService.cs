using BLL.Services.Abstracts;
using DAL.Repository.Abstracts;
using MODEL.Entities;

namespace BLL.Services.Concretes
{
    public class BranchService : ServiceManager<Branch>, IBranchService
    {
        public BranchService(IRepository<Branch> repository) : base(repository)
        {
        }
    }
}
