using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UniversityWebSite.Business.Abstract;

namespace UniversityWebSite.UI.Controllers
{
    public class AccountController : Controller
    {
        IAdminService _adminService;
        public AccountController(IAdminService adminService)
        {
            _adminService = adminService;
        }


        [HttpGet("Login")]
        public IActionResult Authenticate(string returnUrl)
        {
            if (string.IsNullOrEmpty(returnUrl))
            {
                returnUrl = "/dashboard";
            }
            ViewData["ReturnUrl"] = returnUrl;

            if (User.Identity.IsAuthenticated)
            {
                return Redirect("/dashboard");
            }
            else
            {
                return View();
            }
        }

        [ValidateAntiForgeryToken]
        [HttpPost("Login")]
        public async Task<IActionResult> Validate(string username, string password, string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;

            var result = _adminService.IsThereAdmin(username, password);

            if (result)
            {
                var userClaims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, username),
                    new Claim("username", username),
                    new Claim("password", password)

                };
                var userIdentity = new ClaimsIdentity(userClaims, "User Identity");

                var claimsPrincipal = new ClaimsPrincipal(new[] { userIdentity });
                await HttpContext.SignInAsync(claimsPrincipal);

                return Redirect(returnUrl);
            }
            else
            {
                TempData["Error"] = "Error. Username or Password is invalid.";
                return View("Authenticate");
            }
        }
    }
}
