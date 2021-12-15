using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityWebSite.DataAccess.Concrete.Contexts
{
    class EfContext:DbContext
    {
        public EfContext(DbContextOptions<EfContext> options):base(options)
        {

        }

        // Models
        // public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
