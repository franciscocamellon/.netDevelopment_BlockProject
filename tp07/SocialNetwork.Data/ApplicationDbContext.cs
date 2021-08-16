using Microsoft.EntityFrameworkCore;

namespace SocialNetwork.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SocialNetwork.Domain.Entities.Developer> Developer { get; set; }
        public DbSet<SocialNetwork.Domain.Entities.Profile> Profile { get; set; }
    }
}
