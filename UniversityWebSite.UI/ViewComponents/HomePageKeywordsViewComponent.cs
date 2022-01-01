using Microsoft.AspNetCore.Mvc;
using UniversityWebSite.Business.Abstract;

namespace UniversityWebSite.UI.ViewComponents
{
    public class HomePageKeywordsViewComponent : ViewComponent
    {
        IKeywordService _keywordService;

        public HomePageKeywordsViewComponent(IKeywordService keywordService)
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
