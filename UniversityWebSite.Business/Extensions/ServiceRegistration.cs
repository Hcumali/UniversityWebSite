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

            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IAdminService, AdminManager>();
            
        }

    }
}