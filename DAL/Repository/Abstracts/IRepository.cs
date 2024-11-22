using MODEL.Concretes;
using MODEL.Entities;
using System.Linq.Expressions;

namespace DAL.Repository.Abstracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetActives();
        IQueryable<T> GetPassives();
        T GetById(int id);
        Task CreateAsync(T entity);
        Task CreateRangeAsync(List<T> entities);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(List<T> entities);
        Task DeleteAsync(T entity);
        Task DeleteAllAsync(List<T> entities);
        Task DestroyAsync(T entity);
        Task DestroyRangeAsync(List<T> entities);
        Task UpdateAsync(Student student);
    }
}
