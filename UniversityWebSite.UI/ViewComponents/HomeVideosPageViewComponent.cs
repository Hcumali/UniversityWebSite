﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityWebSite.UI.ViewComponents
{
    public class HomeVideosPageViewComponent : ViewComponent
    {
        public HomeVideosPageViewComponent()
        {
                
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
