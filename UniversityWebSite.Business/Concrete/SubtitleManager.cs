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
    public class SubtitleManager : ISubtitleService
    {
        ISubtitleRepository _subtitleRepository;

        public SubtitleManager(ISubtitleRepository subtitleRepository)
        {
            _subtitleRepository = subtitleRepository;
        }

        public void CreateSubtitle(Subtitle subtitle)
        {
            _subtitleRepository.Create(subtitle);
        }

        public void DeleteSubtitle(int id)
        {
            _subtitleRepository.Delete(id);
        }

        public void DeleteSubtitleByCategoryId(int categoryId)
        {
            _subtitleRepository.DeleteByCategoryId(categoryId);
        }

        public void UpdateSubtitle(Subtitle subtitle)
        {
            _subtitleRepository.Update(subtitle);
        }
    }
}
