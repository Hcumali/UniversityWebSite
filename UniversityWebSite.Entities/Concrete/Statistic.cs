using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityWebSite.Entities.Concrete
{
    public class Statistic : BaseEntity
    {
        public int NumberOfStudent { get; set; }
        public int NumberOfFaculty { get; set; }
        public int NumberOfProject { get; set; }
        public int NumberOfTeacher { get; set; }
    }
}
