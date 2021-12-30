using Microsoft.AspNetCore.Mvc;
using UniversityWebSite.Business.Abstract;

namespace UniversityWebSite.UI.ViewComponents
{
    public class HomePicturesPageViewComponent : ViewComponent
    {
        IPictureService _pictureService;

        public HomePicturesPageViewComponent(IPictureService pictureService)
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
