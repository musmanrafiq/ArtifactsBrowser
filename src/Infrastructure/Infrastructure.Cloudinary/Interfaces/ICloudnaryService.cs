using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Cloudinary.Interfaces
{
    public interface ICloudinaryService
    {
        Task UploadImageAsync(string fileNameWithExtension);
        Task<List<string>> GetListAsync();
    }
}
