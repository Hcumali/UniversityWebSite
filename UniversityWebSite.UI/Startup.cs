using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityWebSite.Business.Extensions;

namespace UniversityWebSite.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            // Cookie OAuth
            services.AddAuthentication("CookieAuth")
                .AddCookie("CookieAuth", options => {
                    options.Cookie.Name = "Authenticate";
                    options.LoginPath = "/Login";
                    options.Events = new CookieAuthenticationEvents()
                    {
                        OnSigningIn = async context =>
                        {
                            await Task.CompletedTask;
                        },
                        OnSignedIn = async context =>
                        {
                            await Task.CompletedTask;
                        },
                        OnValidatePrincipal = async context =>
                        {
                            await Task.CompletedTask;
                        }
                    };
                });

            services.AddBusinessRegistration(Configuration); 
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            // Middlewares
            //-----------------------------------------------------
            app.UseHttpsRedirection();

            // wwwroot folder
            app.UseStaticFiles();

            // Routing to page
            app.UseRouting();

            // Who are you ?
            app.UseAuthentication();

            // Are you allowed ?
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
