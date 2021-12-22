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
    public class AdminRepository : EfGenericRepository<Admin>, IAdminRepository
    {
        EfContext _context;
        public AdminRepository(EfContext context) : base(context)
        {
            _context = context;
        }

        // Bu class içinde, hazır fonksiyonlarımızı override edebiliriz.
        public override void Update(Admin entity)
        {
            entity.UpdatedTime = DateTime.Now;
            entity.Username = "Hüseyin";
            _context.Set<Admin>().Update(entity);
            _context.SaveChanges();
        }

        // IAdminRepository interface'indeki ekstra ihtiyaç duyduğumuz fonksiyonları kodlarız.
        public Admin EkstraFonksiyon(Admin admin)
        {
            throw new NotImplementedException();
        }
    }
}
