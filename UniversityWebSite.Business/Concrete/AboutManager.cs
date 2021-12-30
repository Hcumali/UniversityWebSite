using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.DataAccess.Abstract.Repositories;
using UniversityWebSite.Entities.Concrete;

namespace UniversityWebSite.Business.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutRepository _aboutRepository;
        public AboutManager(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public About GetAboutById(int id)
        {
            return _aboutRepository.Get(x => x.Id == id);
        }

        public IEnumerable<About> GetAllAbout()
        {
            return _aboutRepository.GetAll();
        }

        public void UpdateAbout(About about)
        {
            _aboutRepository.Update(about);
        }
    }
}
