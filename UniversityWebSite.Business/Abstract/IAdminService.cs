using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityWebSite.Business.Abstract
{
    public interface IAdminService
    {
        bool IsThereAdmin(string username, string password);
    }
}
