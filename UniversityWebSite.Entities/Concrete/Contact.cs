using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityWebSite.Entities.Concrete
{
    public class Contact : BaseEntity
    {
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
    }
}
