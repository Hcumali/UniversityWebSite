using Microsoft.AspNetCore.Mvc;
using UniversityWebSite.Business.Abstract;

namespace UniversityWebSite.UI.ViewComponents
{
    public class HomePageAboutViewComponent : ViewComponent
    {
        IAboutService _aboutService;

        public HomePageAboutViewComponent(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var about = _aboutService.GetAboutById(1);
            ViewData["CreatedTime"] = about.CreatedTime;
            return View(about);
        }
    }
}
