using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    interface IRepository <T> where T:class, new()
    {
        Task<T> Get(string id);
        Task<T> Find(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void AddRange(IEnumerable<T> emtities); 
        
        void Update(T entity);
        void UpdateRange(IEnumerable<T> emtities);
        
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> emtities);


    }
}
