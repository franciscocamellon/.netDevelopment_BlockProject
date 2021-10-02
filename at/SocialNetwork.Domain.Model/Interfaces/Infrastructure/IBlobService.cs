using System.IO;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Model.Interfaces.Infrastructure
{
    public interface IBlobService
    {
        Task<string> UploadAsync(Stream stream);
        Task DeleteAsync(string blobName);
    }
}
