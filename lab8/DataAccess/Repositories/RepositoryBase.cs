using Domain.Interfaces;
using OnlineShop.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Microsoft.VisualBasic;

namespace DataAccess.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected OnlineShopContext Repository { get; set; }
        public RepositoryBase(OnlineShopContext repositoryContext)
        {
            Repository = repositoryContext;
        }

        public async Task<List<T>> FindAll() => await Repository.Set<T>().AsNoTracking().ToListAsync();
        public async Task<List<T>> FindByCondition(Expression<Func<T, bool>> expression) =>
            await Repository.Set<T>().Where(expression).AsNoTracking().ToListAsync();
        public async Task Create(T entity) => await Repository.Set<T>().AddAsync(entity);
        public async Task Update(T entity) => Repository.Set<T>().Update(entity);
        public async Task Delete(T entity) => Repository.Set<T>().Remove(entity);
    }
}
