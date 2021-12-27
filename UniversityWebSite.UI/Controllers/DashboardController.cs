using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using UniversityWebSite.Entities.Concrete;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.UI.Models;

namespace UniversityWebSite.UI.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        ICategoryService _categoryService;
        ISubtitleService _subtitleService;
        public DashboardController(ICategoryService categoryService, ISubtitleService subtitleService)
        {
            _categoryService = categoryService;
            _subtitleService = subtitleService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReadCategory(string page)
        {
            ViewData["pageName"] = page;
            return View();
        }

        public IActionResult CreateCategory(string page)
        {
            return View();
        }

        [HttpPost]
        public void CreateCategory(CreateCategoryForm createCategoryForm)
        {
            Category category = new Category();

            category.Name = createCategoryForm.CategoryName;
            category.NavBarHeader = (Entities.Enums.NavBarHeader)EnumParser(createCategoryForm.NavBarHeader);
            _categoryService.CreateCategory(category);

            if(createCategoryForm.Subtitles != null)
            {
                var Category = _categoryService.GetCategoryByName(category.Name); // For the use id
                for (int i = 0; i < createCategoryForm.Subtitles.Count; i++)
                {
                    Subtitle subtitle = new Subtitle();
                    subtitle.Name = createCategoryForm.Subtitles[i];
                    subtitle.CategoryId = Category.Id;
                    _subtitleService.CreateSubtitle(subtitle);
                }
            }
        }

        public Enum EnumParser(string expression)
        {
            switch (expression)
            {
                case "University":
                    return UniversityWebSite.Entities.Enums.NavBarHeader.University;
                case "Academic":
                    return UniversityWebSite.Entities.Enums.NavBarHeader.Academic;
                case "Research":
                    return UniversityWebSite.Entities.Enums.NavBarHeader.Research;
                case "Specialization":
                    return UniversityWebSite.Entities.Enums.NavBarHeader.Specialization;
                case "FastAccess":
                    return UniversityWebSite.Entities.Enums.NavBarHeader.FastAccess;
                default:
                    throw new Exception("Something went wrong");
            }
        }

        public IActionResult UpdateCategory(string page, int id)
        {
            ViewData["pageName"] = page;
            ViewData["id"] = id;
            return View();
        }

        public IActionResult DeleteCategory(string page, int id)
        {
            _subtitleService.DeleteSubtitleByCategoryId(id);
            _categoryService.DeleteCategory(id);

            string stringRoute = "/Dashboard/ReadCategory?page=" + page;
            return Redirect(stringRoute);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return Redirect("/");
        }
    }
}
