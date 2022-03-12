using System.Collections.Generic;
using System.Threading.Tasks;

namespace AM.Infrastructure.Interfaces
{
    public interface IArtifactService
    {
        Task UploadImageAsync(string fileNameWithExtension);
        Task<List<string>> GetListAsync();
    }
}
