using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.Entities.Concrete;

namespace UniversityWebSite.Business.Abstract
{
    public interface IAboutService
    {
        About GetAboutById(int id);
        IEnumerable<About> GetAllAbout();
        void UpdateAbout(About about);
    }
}
