using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityWebSite.Entities
{
    public abstract class BaseEntity:IEntity
    {
        // Abstract word, ensures that, this class cannot be new.

        public BaseEntity()
        {
            CreatedTime = DateTime.Now;
            // UpdatedTime.HasValue - cife sor.
        }

        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; } // Nullable

    }

    public interface IEntity
    {
        // The class, inheriting from this interface, is a database table, other than BaseEntity.
    }
}
