using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UniversityWebSite.DataAccess.Concrete.Contexts;

namespace UniversityWebSite.Business.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddBusinessRegistration(this IServiceCollection services,IConfiguration configuration)
        {
            // services.AddScoped<IUserRepository, UserRepository>(); // 1 client 1 , (Singleton) butun client lar için 1 tane , (Transient)

            // services.AddDbContext<>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // services.AddDbContext<EfContext>();

            services.AddDbContext<EfContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString(configuration.GetConnectionString("DefaultConnection"))));
            
        }

    }
}
