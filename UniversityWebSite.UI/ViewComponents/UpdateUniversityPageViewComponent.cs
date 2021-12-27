using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.Entities.Enums;

namespace UniversityWebSite.UI.ViewComponents
{
    public class UpdateUniversityPageViewComponent : ViewComponent
    {
        ICategoryService _categoryService;
        public UpdateUniversityPageViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var universityCategories = _categoryService.GetCategoryByHeader(NavBarHeader.University);
            return View(universityCategories);
        }
    }
}
