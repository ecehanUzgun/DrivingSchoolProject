using BLL.Services.Abstracts;
using DAL.Repository.Abstracts;
using Microsoft.EntityFrameworkCore;
using MODEL.Entities;

namespace BLL.Services.Concretes
{
    public class BranchService : ServiceManager<Branch>, IBranchService
    {
        public BranchService(IRepository<Branch> repository) : base(repository)
        {
            
        }

        public async Task<List<Branch>> GetAllBranchesAsync()
        {
            return GetAll().ToList();
        }

        //BranchId'ye göre Students filtreleme işlemi
        public async Task<List<Student>> GetStudentsByBranchId(int? branchId)
        {
            if (branchId.HasValue)
            {
                //Şube ID'sine göre öğrencileri getir
                return await _repository.GetAll().
                    Where(branch => branch.ID == branchId.Value)
                    .SelectMany(branch => branch.Students)
                    .ToListAsync();
            }

            // Şube ID filtrelenmemişse tüm öğrencileri getir.
            return await _repository.GetAll()
                .SelectMany (branch => branch.Students)
                .ToListAsync();
        }
    }
}
