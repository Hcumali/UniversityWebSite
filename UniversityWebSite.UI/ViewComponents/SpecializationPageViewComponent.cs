using Microsoft.AspNetCore.Mvc;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.Entities.Enums;

namespace UniversityWebSite.UI.ViewComponents
{
    public class SpecializationPageViewComponent : ViewComponent
    {
        ICategoryService _categoryService;
        public SpecializationPageViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var specializationCategories = _categoryService.GetCategoryByHeader(NavBarHeader.Specialization);
            return View(specializationCategories);
        }
    }
}
