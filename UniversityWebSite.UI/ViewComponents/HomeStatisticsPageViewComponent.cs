using Microsoft.AspNetCore.Mvc;
using UniversityWebSite.Business.Abstract;

namespace UniversityWebSite.UI.ViewComponents
{
    public class HomeStatisticsPageViewComponent : ViewComponent
    {
        IStatisticService _statisticService;

        public HomeStatisticsPageViewComponent(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }

        public IViewComponentResult Invoke()
        {
            var statistic = _statisticService.GetStatisticById(1);
            return View(statistic);
        }
    }
}
