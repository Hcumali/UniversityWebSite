using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityWebSite.Entities.Concrete
{
    public class AboutUs : BaseEntity
    {
        public string Paragraph { get; set; }

        // One to many 
        public virtual List<Box> Boxes { get; set; }
    }
}
