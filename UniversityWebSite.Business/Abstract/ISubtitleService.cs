using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.Entities.Concrete;

namespace UniversityWebSite.Business.Abstract
{
    public interface ISubtitleService
    {
        void CreateSubtitle(Subtitle subtitle);
        void DeleteSubtitle(int id);
        void DeleteSubtitleByCategoryId(int categoryId);
        void UpdateSubtitle(Subtitle subtitle);


    }
}
