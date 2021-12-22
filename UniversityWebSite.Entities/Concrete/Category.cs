using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.Entities.Enums;

namespace UniversityWebSite.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public NavBarHeader NavBarHeader { get; set; }
        public string Name { get; set; }
        public List<string> Subtitle { get; set; }
    }
}
