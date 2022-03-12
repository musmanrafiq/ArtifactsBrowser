using AM.Infrastructure.Interfaces;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class CloudinaryService : IArtifactService
    {
        #region public methods

        public async Task UploadImageAsync(string fileNameWithExtension)
        {
            var cloudnary = GetService();

            var imageUploadParams = new ImageUploadParams()
            {
                File = new FileDescription(fileNameWithExtension)
            };
            _ = await cloudnary.UploadAsync(imageUploadParams);
        }

        public async Task<List<string>> GetListAsync()
        {
            var list = new List<string>();
            var cloudnary = GetService();
            var allResources = await cloudnary.ListResourcesAsync();
            if (allResources.StatusCode is System.Net.HttpStatusCode.OK)
            {
                foreach (Resource resource in allResources.Resources)
                {
                    list.Add(resource.SecureUrl.AbsoluteUri);
                }
            }
            return list;
        }

        #endregion

        #region private methods

        private CloudinaryDotNet.Cloudinary GetService()
        {
            var cloudnary = new CloudinaryDotNet.Cloudinary(new Account
            {
                ApiKey = Credientials.ApiKey,
                ApiSecret = Credientials.ApiSecret,
                Cloud = Credientials.CloudName
            });
            return cloudnary;
        }
        #endregion

    }
}
