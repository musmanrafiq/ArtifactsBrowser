using AM.Infrastructure;
using AM.Infrastructure.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace AM.Client.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // DI container registration
            var serviceProvider = new ServiceCollection()
                .AddKeyedSingleton<IArtifactService, S3Service>("S3")
                .AddKeyedSingleton<IArtifactService, CloudinaryService>("Cloudinary")

                .BuildServiceProvider();

            // get cloudinaryservice object
            var cloudinaryService = serviceProvider.GetKeyedService<IArtifactService>("S3");
            // get list of artifacts
            var list = await cloudinaryService.GetListAsync();
            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}
