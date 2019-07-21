using Brunel_Sailing_Web.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Brunel_Sailing_Web.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class 
    {
        protected ApplicationContext ApplicationContext { get; set; }

        public RepositoryBase(ApplicationContext context)
        {
            this.ApplicationContext = context;
        }

        public IQueryable<T> FindAll()
        {
            return this.ApplicationContext.Set<T>();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.ApplicationContext.Set<T>().Where(expression);
        }

        public void Create(T entity)
        {
            this.ApplicationContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.ApplicationContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.ApplicationContext.Set<T>().Remove(entity);
        }

        public async Task SaveAsync()
        {
            await this.ApplicationContext.SaveChangesAsync();
        }
    }
}
