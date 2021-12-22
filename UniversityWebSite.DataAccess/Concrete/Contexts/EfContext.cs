using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.Entities.Concrete;

namespace UniversityWebSite.DataAccess.Concrete.Contexts
{
    public class EfContext:DbContext
    {
        public EfContext(DbContextOptions<EfContext> options):base(options)
        {

        }

        // Models
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Box> Boxes { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Keyword> Keywords { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Fluent APIs
        }
    }
}
