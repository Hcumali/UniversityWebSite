using Microsoft.AspNetCore.Mvc;
using UniversityWebSite.Business.Abstract;

namespace UniversityWebSite.UI.ViewComponents
{
    public class HomeVideosPageViewComponent : ViewComponent
    {
        IVideoService _videoService;

        public HomeVideosPageViewComponent(IVideoService videoService)
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
