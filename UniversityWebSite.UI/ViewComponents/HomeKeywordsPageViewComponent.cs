using Microsoft.AspNetCore.Mvc;
using UniversityWebSite.Business.Abstract;

namespace UniversityWebSite.UI.ViewComponents
{
    public class HomeKeywordsPageViewComponent : ViewComponent
    {
        IKeywordService _keywordService;

        public HomeKeywordsPageViewComponent(IKeywordService keywordService)
        {
            _keywordService = keywordService;
        }

        public IViewComponentResult Invoke()
        {
            var keywords = _keywordService.GetAllKeyword();
            return View(keywords);
        }
    }
}
