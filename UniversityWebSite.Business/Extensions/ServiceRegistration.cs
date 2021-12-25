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
            services.AddDbContext<EfContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IAdminService, AdminManager>();
            
        }

    }
}