using MODEL.Entities;

namespace BLL.Services.Abstracts
{
    public interface IBranchService:IServiceManager<Branch>
    {
        // Tüm şubeleri getir
        Task<List<Branch>> GetAllBranchesAsync();   
        
        // Şube ID'sine göre öğrencileri getirir, tüm öğrencileri getirmek için branchId null olabilir.
        Task<List<Student>> GetStudentsByBranchId(int? branchId);
    }
}
