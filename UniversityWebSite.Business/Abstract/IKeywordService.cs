using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.Entities.Concrete;

namespace UniversityWebSite.Business.Abstract
{
    public interface IKeywordService
    {
        Keyword GetKeywordById(int id);
        IEnumerable<Keyword> GetAllKeyword();
        void UpdateKeyword(Keyword keyword);
    }
}
