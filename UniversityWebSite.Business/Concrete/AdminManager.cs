using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.DataAccess.Abstract.Repositories;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.Entities.Concrete;

namespace UniversityWebSite.Business.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminRepository _adminRepository;

        public AdminManager(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public bool IsThereAdmin(string username, string password)
        {
            var isThereAdmin = _adminRepository.Get(x => x.Username == username && x.Password == password);
            if (isThereAdmin != null)
            {
                return true;
            }
            else return false;
        }
    }
}
