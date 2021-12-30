using Microsoft.AspNetCore.Mvc;
using UniversityWebSite.Business.Abstract;

namespace UniversityWebSite.UI.ViewComponents
{
    public class HomeAboutPageViewComponent : ViewComponent
    {
        IAboutService _aboutService;

        public HomeAboutPageViewComponent(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var about = _aboutService.GetAboutById(1);
            return View(about);
        }
    }
}
