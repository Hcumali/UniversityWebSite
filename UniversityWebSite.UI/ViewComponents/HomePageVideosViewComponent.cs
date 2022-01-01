using Microsoft.AspNetCore.Mvc;
using UniversityWebSite.Business.Abstract;

namespace UniversityWebSite.UI.ViewComponents
{
    public class HomePageVideosViewComponent : ViewComponent
    {
        IVideoService _videoService;

        public HomePageVideosViewComponent(IVideoService videoService)
        {
            _videoService = videoService;
        }

        public IViewComponentResult Invoke()
        {
            var videos = _videoService.GetAllVideo();
            return View(videos);
        }
    }
}
