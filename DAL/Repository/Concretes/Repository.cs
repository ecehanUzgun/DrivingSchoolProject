using DAL.Context;
using DAL.Repository.Abstracts;
using Microsoft.EntityFrameworkCore;
using MODEL.Concretes;
using System.Linq.Expressions;

namespace DAL.Repository.Concretes
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ProjectContext _context;
        private readonly DbSet<T> _dbSet;
        public Repository(ProjectContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task CreateAsync(T entity)
        {
            _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task CreateRangeAsync(List<T> entities)
        {
            _dbSet.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAllAsync(List<T> entities)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(T entity)
        {
            entity.Status = MODEL.Enums.DataStatus.Passive;
            entity.UpdatedDate = DateTime.Now;
            await UpdateAsync(entity);
        }

        public async Task DestroyAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DestroyRangeAsync(List<T> entities)
        {
            foreach (var entity in entities) 
            { 
                await DestroyAsync(entity);
            }
        }

        public IQueryable<T> GetActives()
        {
            return _dbSet.Where(x => x.Status == MODEL.Enums.DataStatus.Active);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public T GetById(int id)
        {
            return _dbSet.FirstOrDefault(x => x.ID == id);
        }

        public IQueryable<T> GetPassives()
        {
            return _dbSet.Where(x => x.Status == MODEL.Enums.DataStatus.Passive);
        }

        public async Task UpdateAsync(T entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.UpdatedComputerName = System.Environment.MachineName;

            T originalEntity = GetById(entity.ID);

            _dbSet.Entry(originalEntity).CurrentValues.SetValues(entity);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateRangeAsync(List<T> entities)
        {
            foreach (var item in entities)
            {
                await UpdateAsync(item);
            }
        }
    }
}

