using Microsoft.AspNetCore.Mvc;
using System;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.Entities.Concrete;

namespace UniversityWebSite.UI.ViewComponents
{
    public class HomePagePicturesUpdateViewComponent : ViewComponent
    {
        IPictureService _pictureService;

        public HomePagePicturesUpdateViewComponent(IPictureService pictureService)
        {
            _pictureService = pictureService;
        }

        public IViewComponentResult Invoke()
        {
            int id = Convert.ToInt32(ViewData["id"]);
            Picture picture = _pictureService.GetPictureById(id);
            ViewData["CreatedTime"] = picture.CreatedTime;
            return View(picture);
        }
    }
}
