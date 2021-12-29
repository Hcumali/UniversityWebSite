using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityWebSite.UI.Models
{
    public class UpdateCategoryForm
    {
        public string NavBarHeader { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<SubtitleLocal> Subtitles { get; set; }
    }

    public class SubtitleLocal
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
