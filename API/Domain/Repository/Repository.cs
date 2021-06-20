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

        public virtual async Task<T> Get(string id)
            => await context.Set<T>().FindAsync(id);

        public virtual async Task<T> Find(Expression<Func<T, bool>> predicate)
            => await context.Set<T>().FirstOrDefaultAsync(predicate);


        public virtual async Task<IEnumerable<T>> GetAll()
            => await context.Set<T>().ToListAsync();
        public virtual async Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate)
            => await context.Set<T>().Where(predicate).ToListAsync();


        public virtual void Add(T entity)
         =>  context.Set<T>().Add(entity);
        
        public virtual void AddRange(IEnumerable<T> emtities)
         =>  context.Set<T>().AddRange(emtities);


        public virtual void Update(T entity)
         =>  context.Set<T>().Update(entity);
        
        public virtual void UpdateRange(IEnumerable<T> emtities)
         =>  context.Set<T>().UpdateRange(emtities);
        
        
        public virtual void Delete(T entity)
         =>  context.Set<T>().Update(entity);

        public virtual void DeleteRange(IEnumerable<T> emtities)
            =>  context.Set<T>().UpdateRange(emtities);

    }
}
