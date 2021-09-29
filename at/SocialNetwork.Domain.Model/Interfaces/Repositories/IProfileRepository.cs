using System.Threading.Tasks;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Model.Interfaces.Repositories
{
    public interface IProfileRepository
    {
        Task<Profile> GetProfileByUserIdAsync(string userId);
        Task InsertAsync(Profile profile);
        Task UpdateAsync(Profile profile);
    }
}
