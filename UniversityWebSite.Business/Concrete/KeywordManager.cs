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
    public class KeywordManager : IKeywordService
    {
        IKeywordRepository _keywordRepository;
        public KeywordManager(IKeywordRepository keywordRepository)
        {
            _keywordRepository = keywordRepository;
        }

        public IEnumerable<Keyword> GetAllKeyword()
        {
            return _keywordRepository.GetAll();
        }

        public Keyword GetKeywordById(int id)
        {
            return _keywordRepository.Get(x => x.Id == id);
        }

        public void UpdateKeyword(Keyword keyword)
        {
            _keywordRepository.Update(keyword);
        }
    }
}
