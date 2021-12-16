using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.DataAccess.Abstract;
using UniversityWebSite.Entities;

namespace UniversityWebSite.DataAccess.Concrete.Repositories
{
    public class EfGenericRepository<T> : IGenericRepository<T>  where T : class, IEntity, new()
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _setEntity;

        public EfGenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _setEntity = _dbContext.Set<T>();
        }

        public virtual void Create(T entity)
        {
            //_dbContext.Add(entity);  -- Alternative

            _setEntity.Add(entity);
            _dbContext.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public virtual T Read(int id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> Read(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(T entity)
        {
            // cife sor burayı da, t ile updated tima nasıl ulasırız.
            // sturtupa context meselesi
            // önceki projede o generiği neden tekrar inherit aldıgımızı sor.
            // bir de baseentity hasvalue olayını sor.
            _setEntity.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
