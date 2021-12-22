using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace UniversityWebSite.UI.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("read")]
        public IActionResult ReadCategory(string page)
        {
            ViewData["pageName"] = page;
            return View();
        }

        [HttpGet("create")]
        public IActionResult CreateCategory(string page)
        {
            ViewData["pageName"] = page;
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost("create")]
        public IActionResult CreateCategory(int model)
        {
            return View();
        }

        [HttpGet("update")]
        public IActionResult UpdateCategory(string page)
        {
            ViewData["pageName"] = page;
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost("update")]
        public IActionResult UpdateCategory(int test)
        {
            return View();
        }

        [HttpPost("delete")]
        public IActionResult DeleteCategory(int id)
        {
            // delete process
            return View("read");
        }


        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return Redirect("/");
        }
    }
}
