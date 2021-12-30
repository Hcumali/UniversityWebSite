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
    public class AboutRepository : EfGenericRepository<About>, IAboutRepository
    {
        EfContext _context;
        public AboutRepository(EfContext context) : base(context)
        {
            _context = context;
        }

        public override About Get(Expression<Func<About, bool>> filter)
        {
            return _context.Set<About>().Include(x => x.Boxes).SingleOrDefault(filter);
        }
    }
}
