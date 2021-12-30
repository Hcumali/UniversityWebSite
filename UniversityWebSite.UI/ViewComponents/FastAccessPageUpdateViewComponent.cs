using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.Entities.Concrete;
using UniversityWebSite.Entities.Enums;

namespace UniversityWebSite.UI.ViewComponents
{
    public class FastAccessPageUpdateViewComponent : ViewComponent
    {
        ICategoryService _categoryService;

        public FastAccessPageUpdateViewComponent(ICategoryService categoryService)
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
