using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.Entities.Abstract;

namespace UniversityWebSite.Entities.Concrete
{
    public abstract class BaseEntity : IEntity
    {
        // Abstract word, ensures that, this class cannot be new.
        public BaseEntity()
        {
            CreatedTime = DateTime.Now;
            // UpdatedTime.HasValue 
        }

        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; } // Nullable
    }
}
