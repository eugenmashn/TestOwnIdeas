using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public class Repository<T> : IRepository<T> where T:class, new()
    {
        protected readonly MyDbContext context;
        
        public Repository(MyDbContext dbContext)
        {
            context = dbContext;
        }

        public async Task<T> Get(string id)
            => await context.Set<T>().FindAsync(id);

        public async Task<T> Find(Expression<Func<T, bool>> predicate)
            => await context.Set<T>().FirstOrDefaultAsync(predicate);


        public async Task<IEnumerable<T>> GetAll()
            => await context.Set<T>().ToListAsync();
        public async Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate)
            => await context.Set<T>().Where(predicate).ToListAsync();


        public void Add(T entity)
         =>  context.Set<T>().Add(entity);
        
        public void AddRange(IEnumerable<T> emtities)
         =>  context.Set<T>().AddRange(emtities);


        public void Update(T entity)
         =>  context.Set<T>().Update(entity);
        
        public void UpdateRange(IEnumerable<T> emtities)
         =>  context.Set<T>().UpdateRange(emtities);
        
        
        public void Delete(T entity)
         =>  context.Set<T>().Update(entity);

        public void DeleteRange(IEnumerable<T> emtities)
            =>  context.Set<T>().UpdateRange(emtities);

    }
}
