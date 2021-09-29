using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialNetwork.Data;
using SocialNetwork.Data.Repositories;
using SocialNetwork.Domain.Model.Interfaces.Repositories;
using SocialNetwork.Domain.Model.Interfaces.Services;
using SocialNetwork.Domain.Services.Services;
using System.Configuration;

namespace Crosscutting.IoC
{
    public static class Bootstrapper
    {
        public static void RegisterServices(
            this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IPostRepository, PostRepository>();
            services.AddTransient<IProfileRepository, ProfileRepository>();
            services.AddTransient<IAlbumRepository, AlbumRepository>();
            services.AddTransient<IPictureRepository, PictureRepository>();
            services.AddTransient<IPictureService, PictureServices>();
            services.AddTransient<IAlbumService, AlbumServices>();

            
        }
    }
}
