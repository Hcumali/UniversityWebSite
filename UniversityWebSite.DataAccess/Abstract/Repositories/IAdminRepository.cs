using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.Entities;

namespace UniversityWebSite.DataAccess.Abstract.Repositories
{
    public interface IAdminRepository : IGenericRepository<Admin>
    {

        // Ekstradan ihtiyaç duyulan fonksiyonlar da burada yazılmalıdır.
        Admin EkstraFonksiyon(Admin admin);

    }
}
