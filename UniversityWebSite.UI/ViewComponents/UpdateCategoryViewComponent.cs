using Microsoft.AspNetCore.Mvc;
using System;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.Entities.Concrete;

namespace UniversityWebSite.UI.ViewComponents
{
    public class UpdateCategoryViewComponent : ViewComponent
    {
        ICategoryService _categoryService;

        public UpdateCategoryViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            int id = Convert.ToInt32(ViewData["id"]);
            Category category = _categoryService.GetCategoryById(id);
            ViewData["CreatedTime"] = category.CreatedTime;
            return View(category);
        }
    }
}
