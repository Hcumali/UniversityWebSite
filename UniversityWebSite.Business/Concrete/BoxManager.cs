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
    public class BoxManager : IBoxService
    {
        IBoxRepository _boxRepository;
        public BoxManager(IBoxRepository boxRepository)
        {
            _boxRepository = boxRepository;
        }

        public IEnumerable<Box> GetAllBox()
        {
            return _boxRepository.GetAll();
        }

        public void UpdateBox(Box box)
        {
            _boxRepository.Update(box);
        }
    }
}
