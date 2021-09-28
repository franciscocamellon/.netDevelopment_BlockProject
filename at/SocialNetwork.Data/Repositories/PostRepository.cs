using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Entities;
using SocialNetwork.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Data.Repositories
{
    public class PostRepository : IPostRepository
    {
        protected readonly ApplicationDbContext _dbContext;

        public PostRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public async Task<IEnumerable<Post>> GetLastPostsAsync()
        {
            return await _dbContext.Posts
                               .Include(x => x.Profile)
                               .OrderByDescending(x => x.Date)
                               .Take(10).ToListAsync();
        }

        public async Task InsertAsync(Post post)
        {
            //business rule
            post.Date = DateTime.Now;

            //objeto já existente no banco
            _dbContext.Attach(post.Profile);

            //repository
            await _dbContext.AddAsync(post);
            await _dbContext.SaveChangesAsync();

        }

    }
}
