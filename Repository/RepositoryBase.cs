using Contracts;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryBase <T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext repositoryContext;

        protected RepositoryBase(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }


        public IQueryable<T> FindAll()
        {
           return repositoryContext.Set<T>();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
          return repositoryContext.Set<T>().Where(expression);
        }
        public void Create(T entity)
        {
            repositoryContext.Set<T>().Add(entity);
        }
        public void Update(T entity) 
        { 
            repositoryContext.Set<T>().Update(entity); 
        }
        public void Delete(T entity) 
        {    
            repositoryContext.Set<T>().Remove(entity);
        }

       
    }
}
