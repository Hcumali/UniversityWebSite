using Microsoft.AspNetCore.Mvc;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.Entities.Enums;

namespace UniversityWebSite.UI.ViewComponents
{
    public class AcademicPageViewComponent : ViewComponent
    {
        ICategoryService _categoryService;
        public AcademicPageViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var academicCategories = _categoryService.GetCategoryByHeader(NavBarHeader.Academic);
            return View(academicCategories);
        }
    }
}
