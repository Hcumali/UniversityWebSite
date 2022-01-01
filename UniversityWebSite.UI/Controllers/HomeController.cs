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
        IAboutService _aboutService;
        IStatisticService _statisticService;
        IKeywordService _keywordService;
        IVideoService _videoService;
        IPictureService _pictureService;
        IContactService _contactService;

        public HomeController
            (
                ICategoryService categoryService, 
                IAboutService aboutService,
                IStatisticService statisticService,
                IKeywordService keywordService,
                IVideoService videoService,
                IPictureService pictureService,
                IContactService contactService 
            )
        {
            _categoryService = categoryService;
            _aboutService = aboutService;
            _statisticService = statisticService;
            _keywordService = keywordService;
            _videoService = videoService;
            _pictureService = pictureService;
            _contactService = contactService;
        }


        public IActionResult Index()
        {
            HomePageViewModel homePageViewModel = new HomePageViewModel()
            {
                Categories = _categoryService.GetAllCategory(),
                About = _aboutService.GetAboutById(1),
                Statistic = _statisticService.GetStatisticById(1),
                Keywords = _keywordService.GetAllKeyword(),
                Videos = _videoService.GetAllVideo(),
                Pictures = _pictureService.GetAllPicture(),
                Contact = _contactService.GetContactById(1)
            };
            return View(homePageViewModel);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
