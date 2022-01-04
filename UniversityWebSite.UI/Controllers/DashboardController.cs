using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using UniversityWebSite.Entities.Concrete;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.UI.Models;
using UniversityWebSite.Business.Concrete;

namespace UniversityWebSite.UI.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        #region Definitions
            ICategoryService _categoryService;
            ISubtitleService _subtitleService;
            IKeywordService _keywordService;
            IPictureService _pictureService;
            IVideoService _videoService;
            IAboutService _aboutService;
            IContactService _contactService;
            IStatisticService _statisticService;
        #endregion

        public DashboardController
            (
                #region Parameters
                    ICategoryService categoryService,
                    ISubtitleService subtitleService,
                    IKeywordService keywordService,
                    IPictureService pictureService,
                    IVideoService videoService,
                    IAboutService aboutService,
                    IContactService contactService,
                    IStatisticService statisticService
                #endregion
            )
        {
            #region Assignments
                _categoryService = categoryService;
                _subtitleService = subtitleService;
                _keywordService = keywordService;
                _pictureService = pictureService;
                _videoService = videoService;
                _aboutService = aboutService;
                _contactService = contactService;
                _statisticService = statisticService;
            #endregion
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
            ViewData["pageName"] = page;
            return View();
        }

        [HttpPost]
        public void CreateCategory(CreateCategoryForm createCategoryForm)
        {
            Category category = new Category();

            category.Name = createCategoryForm.CategoryName;
            category.NavBarHeader = (Entities.Enums.NavBarHeader)EnumManager.EnumParser(createCategoryForm.NavBarHeader);
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

        public IActionResult UpdateCategory(string page, int id)
        {
            ViewData["pageName"] = page;
            ViewData["id"] = id;
            return View();
        }

        [HttpPost]
        public void UpdateCategory(UpdateCategoryForm updateCategoryForm)
        {
            if (updateCategoryForm.CategoryName != null)
            {
                Category category = new Category()
                {
                    Id = updateCategoryForm.CategoryId,
                    CreatedTime = updateCategoryForm.CreatedTime,
                    NavBarHeader = (Entities.Enums.NavBarHeader)EnumManager.EnumParser(updateCategoryForm.NavBarHeader),
                    Name = updateCategoryForm.CategoryName
                };
                _categoryService.UpdateCategory(category);
            }

            if(updateCategoryForm.Subtitles != null)
            {
                for (int i = 0; i < updateCategoryForm.Subtitles.Count; i++)
                {
                    Subtitle subtitle = new Subtitle()
                    {
                        Id = updateCategoryForm.Subtitles[i].Id,
                        CreatedTime = updateCategoryForm.CreatedTime,
                        Name = updateCategoryForm.Subtitles[i].Name,
                        CategoryId = updateCategoryForm.CategoryId
                    };
                    _subtitleService.UpdateSubtitle(subtitle);
                }
            }
        }

        public IActionResult DeleteCategory(string page, int id)
        {
            _subtitleService.DeleteSubtitleByCategoryId(id);
            _categoryService.DeleteCategory(id);

            string stringRoute = "/Dashboard/ReadCategory?page=" + page;
            return Redirect(stringRoute);
        }


        [HttpPost]
        public void UpdateKeyword(Keyword keyword)
        {
            _keywordService.UpdateKeyword(keyword);
        }

        [HttpPost]
        public void UpdatePicture(Picture picture)
        {
            _pictureService.UpdatePicture(picture);
        }

        [HttpPost]
        public void UpdateVideo(Video video)
        {
            _videoService.UpdateVideo(video);
        }

        [HttpPost]
        public void UpdateAbout(About about)
        {
            _aboutService.UpdateAbout(about);
        }

        [HttpPost]
        public void UpdateContact(Contact contact)
        {
            _contactService.UpdateContact(contact);
        }

        [HttpPost]
        public void UpdateStatistic(Statistic statistic)
        {
            _statisticService.UpdateStatistic(statistic);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return Redirect("/");
        }
    }
}
