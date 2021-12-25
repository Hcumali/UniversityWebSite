using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.Entities.Concrete;
using UniversityWebSite.UI.Models;

namespace UniversityWebSite.UI.Controllers
{
    public class HomeController : Controller
    {
        ICategoryService _categoryService;
        public HomeController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        public IActionResult Index()
        {
            IEnumerable<Category> categories = _categoryService.GetAllCategory();

            return View(categories);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
