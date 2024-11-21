using DAL.Context;
using DAL.Repository.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repository.Concretes
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ProjectContext _context;
        private readonly DbSet<T> _dbSet;
        public Repository(ProjectContext context, DbSet<T> dbSet)
        {
            _context = context;
            _dbSet = dbSet;
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
           return _dbSet.Where(predicate).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}
