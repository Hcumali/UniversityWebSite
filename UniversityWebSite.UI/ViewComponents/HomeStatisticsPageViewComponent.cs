﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityWebSite.UI.ViewComponents
{
    public class HomeStatisticsPageViewComponent : ViewComponent
    {
        public HomeStatisticsPageViewComponent()
        {

        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}