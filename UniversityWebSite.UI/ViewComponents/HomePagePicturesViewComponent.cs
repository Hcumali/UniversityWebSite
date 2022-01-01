using Microsoft.AspNetCore.Mvc;
using UniversityWebSite.Business.Abstract;

namespace UniversityWebSite.UI.ViewComponents
{
    public class HomePagePicturesViewComponent : ViewComponent
    {
        IPictureService _pictureService;

        public HomePagePicturesViewComponent(IPictureService pictureService)
        {
            _pictureService = pictureService;
        }

        public IViewComponentResult Invoke()
        {
            var pictures = _pictureService.GetAllPicture();
            return View(pictures);
        }
    }
}
