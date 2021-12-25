using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityWebSite.Entities.Concrete
{
    public class Subtitle : BaseEntity
    {
        public int Name { get; set; }

        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
