using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityWebSite.Entities.Concrete;

namespace UniversityWebSite.UI.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public About About { get; set; }
        public Statistic Statistic { get; set; }
        public IEnumerable<Keyword> Keywords { get; set; }
        public IEnumerable<Video> Videos { get; set; }
        public IEnumerable<Picture> Pictures { get; set; }
        public Contact Contact { get; set; }

    }
}
