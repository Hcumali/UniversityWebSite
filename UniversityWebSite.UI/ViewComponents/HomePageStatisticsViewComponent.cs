using Microsoft.AspNetCore.Mvc;
using UniversityWebSite.Business.Abstract;

namespace UniversityWebSite.UI.ViewComponents
{
    public class HomePageStatisticsViewComponent : ViewComponent
    {
        IStatisticService _statisticService;

        public HomePageStatisticsViewComponent(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }

        public IViewComponentResult Invoke()
        {
            var statistic = _statisticService.GetStatisticById(1);
            ViewData["CreatedTime"] = statistic.CreatedTime;
            return View(statistic);
        }
    }
}
