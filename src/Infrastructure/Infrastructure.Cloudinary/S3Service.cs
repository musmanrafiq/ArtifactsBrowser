using AM.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class S3Service : IArtifactService

    {
        public Task<List<string>> GetListAsync()
        {
            //throw new NotImplementedException();
            return Task.Run(() => new List<string>() { "Test entry" });
        }

        public Task UploadImageAsync(string fileNameWithExtension)
        {
            throw new NotImplementedException();
        }
    }
}
