﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.Entities.Enums;

namespace UniversityWebSite.UI.ViewComponents
{
    public class UniversityPageViewComponent : ViewComponent
    {
        ICategoryService _categoryService;
        public UniversityPageViewComponent(ICategoryService categoryService)
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
