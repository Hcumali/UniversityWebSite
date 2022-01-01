using Microsoft.AspNetCore.Mvc;

namespace UniversityWebSite.UI.ViewComponents
{
    public class CreateCategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
