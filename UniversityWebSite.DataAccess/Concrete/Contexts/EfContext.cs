using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.Entities.Concrete;
using UniversityWebSite.DataAccess.Concrete.Mappings;
using UniversityWebSite.DataAccess.Concrete.Initializer;
using System.Reflection;

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
        public DbSet<Subtitle> Subtitles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            DataInitializer.Seed(modelBuilder);

            modelBuilder.ApplyConfiguration(new AdminConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new AboutConfig());
            modelBuilder.ApplyConfiguration(new BoxConfig());
            modelBuilder.ApplyConfiguration(new ContactConfig());
            modelBuilder.ApplyConfiguration(new KeywordConfig());
            modelBuilder.ApplyConfiguration(new PictureConfig());
            modelBuilder.ApplyConfiguration(new StatisticConfig());
            modelBuilder.ApplyConfiguration(new SubtitleConfig());
            modelBuilder.ApplyConfiguration(new VideoConfig());
        }
    }
}
