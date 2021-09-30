using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialNetwork.Data;
using System;
using Crosscutting.IoC;
using SocialNetwork.Domain.Model.Entities;
using SocialNetwork.Web.Services;
using SocialNetwork.Web.Services.Implementations;

namespace SocialNetwork.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDefaultIdentity<User>(options => {
                options.SignIn.RequireConfirmedAccount = true;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 3;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddControllersWithViews();
            services.AddRazorPages();

            var profileImageApiAddress = Configuration.GetValue<string>("ApiAddresses:Profile");
            var albumApiAddress = Configuration.GetValue<string>("ApiAddresses:Album");
            var pictureApiAddress = Configuration.GetValue<string>("ApiAddresses:Picture");

            services.AddHttpClient("", client => {
                client.BaseAddress = new Uri(Configuration["BaseUrlApi"]);
            });
            services.AddHttpClient<IAlbumHttpService, AlbumHttpService>(x => 
                x.BaseAddress = new Uri(albumApiAddress));
            services.AddHttpClient<IPictureHttpService, PictureHttpService>(x => 
                x.BaseAddress = new Uri(pictureApiAddress));

            services.RegisterServices(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "Identity",
                    areaName: "Identity",
                    pattern: "Identity/{controller=Account}/{action=Index}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Feed}/{action=Index}");
                endpoints.MapRazorPages();
            });
        }
    }
}
