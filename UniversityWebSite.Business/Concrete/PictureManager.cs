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
    public class PictureManager : IPictureService
    {
        IPictureRepository _pictureRepository;

        public PictureManager(IPictureRepository pictureRepository)
        {
            _pictureRepository = pictureRepository;
        }

        public IEnumerable<Picture> GetAllPicture()
        {
            return _pictureRepository.GetAll();
        }

        public void UpdatePicture(Picture picture)
        {
            _pictureRepository.Update(picture);
        }
    }
}
