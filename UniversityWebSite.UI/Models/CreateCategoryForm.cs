using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityWebSite.Entities.Concrete;

namespace UniversityWebSite.UI.Models
{
    public class CreateCategoryForm
    {
        public string NavBarHeader { get; set; }
        public string CategoryName { get; set; }
        public List<string> Subtitles { get; set; }
    }
}
