using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityWebSite.Entities.Concrete;

namespace UniversityWebSite.UI.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<Category> categories { get; set; }
    }
}
