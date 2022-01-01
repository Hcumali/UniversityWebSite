using Microsoft.AspNetCore.Mvc;
using System;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.Entities.Concrete;

namespace UniversityWebSite.UI.ViewComponents
{
    public class HomePageVideosUpdateViewComponent : ViewComponent
    {
        IVideoService _videoService;

        public HomePageVideosUpdateViewComponent(IVideoService videoService)
        {
            _videoService = videoService;
        }

        public IViewComponentResult Invoke()
        {
            int id = Convert.ToInt32(ViewData["id"]);
            Video video = _videoService.GetVideoById(id);
            ViewData["CreatedTime"] = video.CreatedTime;
            return View(video);
        }
    }
}
