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
            // ID container registration
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IArtifactService, CloudinaryService>()
                .BuildServiceProvider();

            // get cloudinaryservice object
            var cloudinaryService = serviceProvider.GetService<IArtifactService>();
            // get list of artifacts
            var list = await cloudinaryService.GetListAsync();
            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}
