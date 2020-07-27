using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WritersCorner.Data.Context;
using WritersCorner.Service.Implementations;
using WritersCorner.Service.Contracts;
using WritersCorner.Data.Entities;
using WritersCorner.Service.Implementations.UserBookImplementations;
using Microsoft.Extensions.FileProviders;
using WritersCorner.Service.Providers;

namespace WritersCorner
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
            services.AddDbContext<WritersCornerContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<User>(options =>
                options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<WritersCornerContext>();
            
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 5;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;

            });

            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<ISiteinfoServices, SiteInfoServices>();
            services.AddScoped<IFileService, FileService>();

            //Book Services
            services.AddScoped<ICharacterServices, CharacterServices>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                     name: "AdminThings",
                     areaName: "Administrator",
                     pattern: "{area:exists}/{controller=User}/{action=BanUser}/{id?}");


                endpoints.MapAreaControllerRoute(
                     name: "AdminThings",
                     areaName: "Administrator",
                     pattern: "{area:exists}/{controller=User}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
