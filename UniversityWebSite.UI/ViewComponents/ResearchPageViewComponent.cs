using Microsoft.AspNetCore.Mvc;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.Entities.Enums;

namespace UniversityWebSite.UI.ViewComponents
{
    public class ResearchPageViewComponent : ViewComponent
    {
        ICategoryService _categoryService;
        public ResearchPageViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var researchCategories = _categoryService.GetCategoryByHeader(NavBarHeader.Research);
            return View(researchCategories);
        }
    }
}
