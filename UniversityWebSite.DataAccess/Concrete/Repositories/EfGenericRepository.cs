using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.DataAccess.Abstract;
using UniversityWebSite.Entities.Abstract;
using UniversityWebSite.Entities.Concrete;

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
            var convertedEntity = entity as BaseEntity;
            convertedEntity.CreatedTime = DateTime.Now;
            _setEntity.Add(entity);
            _dbContext.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            var willDelete = _setEntity.Find(id);
            _setEntity.Remove(willDelete);
            _dbContext.SaveChanges();
        }

        public virtual T Get(Expression<Func<T, bool>> filter)
        {
            return _setEntity.SingleOrDefault(filter);
        }

        public virtual IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return filter == null
                ? _setEntity.ToList()
                : _setEntity.Where(filter).ToList();
        }

        public virtual void Update(T entity)
        {
            var convertedEntity = entity as BaseEntity;
            convertedEntity.UpdatedTime = DateTime.Now;
            _setEntity.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
