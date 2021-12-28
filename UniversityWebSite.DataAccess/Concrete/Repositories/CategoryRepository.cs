using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.DataAccess.Concrete.Contexts;
using UniversityWebSite.DataAccess.Abstract.Repositories;
using UniversityWebSite.Entities.Concrete;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace UniversityWebSite.DataAccess.Concrete.Repositories
{
    public class CategoryRepository : EfGenericRepository<Category>, ICategoryRepository
    {
        EfContext _context;
        public CategoryRepository(EfContext context) : base(context)
        {
            _context = context;
        }

        public override IEnumerable<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return filter == null
                ? _context.Set<Category>().Include(x => x.Subtitles).ToList()
                : _context.Set<Category>().Where(filter).Include(x => x.Subtitles).ToList();
        }

        public override Category Get(Expression<Func<Category, bool>> filter)
        {
            return _context.Set<Category>().Include(x => x.Subtitles).SingleOrDefault(filter);
        }
    }
}
