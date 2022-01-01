using Microsoft.AspNetCore.Mvc;
using System;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.Entities.Concrete;

namespace UniversityWebSite.UI.ViewComponents
{
    public class HomePageKeywordsUpdateViewComponent : ViewComponent
    {
        IKeywordService _keywordService;

        public HomePageKeywordsUpdateViewComponent(IKeywordService keywordService)
        {
            _keywordService = keywordService;
        }

        public IViewComponentResult Invoke()
        {
            int id = Convert.ToInt32(ViewData["id"]);
            Keyword keyword = _keywordService.GetKeywordById(id);
            ViewData["CreatedTime"] = keyword.CreatedTime;
            return View(keyword);
        }
    }
}
