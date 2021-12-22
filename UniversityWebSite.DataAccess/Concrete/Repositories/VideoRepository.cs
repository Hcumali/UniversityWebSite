using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.DataAccess.Concrete.Contexts;
using UniversityWebSite.DataAccess.Abstract.Repositories;
using UniversityWebSite.Entities.Concrete;

namespace UniversityWebSite.DataAccess.Concrete.Repositories
{
    public class VideoRepository : EfGenericRepository<Video>, IVideoRepository
    {
        EfContext _context;
        public VideoRepository(EfContext context) : base(context)
        {
            _context = context;
        }

        // Extra Functions from the this interface
        // override functions
    }
}
