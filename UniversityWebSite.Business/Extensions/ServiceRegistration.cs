using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UniversityWebSite.DataAccess.Concrete.Contexts;
using UniversityWebSite.DataAccess.Abstract.Repositories;
using UniversityWebSite.DataAccess.Concrete.Repositories;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.Business.Concrete;

namespace UniversityWebSite.Business.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddBusinessRegistration(this IServiceCollection services,IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<EfContext>(options => options.UseSqlServer(connectionString));

            var optionsBuilder = new DbContextOptionsBuilder<EfContext>();
            optionsBuilder.UseSqlServer(connectionString);
            var context = new EfContext(optionsBuilder.Options);
            using (context)
            {
                context.Database.Migrate();
            }

            // Admin
            // DataAccess - Dependency Injection
            services.AddScoped<IAdminRepository, AdminRepository>();
            // Business - Dependency Injection
            services.AddScoped<IAdminService, AdminManager>();

            // Category
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryManager>();

            // Subtitles-> Category
            services.AddScoped<ISubtitleRepository, SubtitleRepository>();
            services.AddScoped<ISubtitleService, SubtitleManager>();

            // Home - About
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IAboutService, AboutManager>();

            // Home - Boxes-> About
            services.AddScoped<IBoxRepository, BoxRepository>();
            services.AddScoped<IBoxService, BoxManager>();

            // Home - Contact
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IContactService, ContactManager>();

            // Home - Keyword
            services.AddScoped<IKeywordRepository, KeywordRepository>();
            services.AddScoped<IKeywordService, KeywordManager>();

            // Home - Pictures
            services.AddScoped<IPictureRepository, PictureRepository>();
            services.AddScoped<IPictureService, PictureManager>();

            // Home - Statistic
            services.AddScoped<IStatisticRepository, StatisticRepository>();
            services.AddScoped<IStatisticService, StatisticManager>();

            //Home - Videos
            services.AddScoped<IVideoRepository, VideoRepository>();
            services.AddScoped<IVideoService, VideoManager>();
        }

    }
}