using Microsoft.AspNetCore.Mvc;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.Business.Concrete;
using UniversityWebSite.Entities.Enums;

namespace UniversityWebSite.UI.ViewComponents
{
    public class ReadCategoryViewComponent : ViewComponent
    {
        ICategoryService _categoryService;
        public ReadCategoryViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var enumString = ViewData["pageName"].ToString();
            var enumType =  (NavBarHeader)EnumManager.EnumParser(enumString);
            var Categories = _categoryService.GetCategoryByHeader(enumType);
            return View(Categories);
        }
    }
}
