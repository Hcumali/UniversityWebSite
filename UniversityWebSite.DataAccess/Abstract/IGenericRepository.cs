using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.Entities.Abstract;

namespace UniversityWebSite.DataAccess.Abstract
{
    public interface IGenericRepository<T> where T : class, IEntity, new()
    {
        // CRUD
        void Create(T entity);
        T Read(int id);
        IEnumerable<T> Read(Expression<Func<T,bool>> filter = null); // Expression ensures to use Lambda Function.
        void Update(T entity);
        void Delete(int id);
    }
}
