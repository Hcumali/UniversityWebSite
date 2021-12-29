using Microsoft.AspNetCore.Mvc;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.Entities.Enums;

namespace UniversityWebSite.UI.ViewComponents
{
    public class FastAccessPageViewComponent : ViewComponent
    {
        ICategoryService _categoryService;
        public FastAccessPageViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var fastAccessCategories = _categoryService.GetCategoryByHeader(NavBarHeader.FastAccess);
            return View(fastAccessCategories);
        }
    }
}
