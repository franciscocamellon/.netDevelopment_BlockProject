using System.Collections.Generic;
using System.Threading.Tasks;
using SocialNetwork.Domain.Model.Entities;

namespace SocialNetwork.Domain.Model.Interfaces.Repositories
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetLastPostsAsync();
        Task InsertAsync(Post post);
    }
}
