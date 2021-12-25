using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityWebSite.Entities.Concrete
{
    public class Box : BaseEntity
    {
        public string Header { get; set; }
        public string Text { get; set; }

        public int? AboutId { get; set; }
        public virtual About About { get; set; }
    }
}
