using Infrastructure.Cloudinary;
using Infrastructure.Cloudinary.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace CloudnaryClient.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // ID container registration
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICloudinaryService, CloudinaryService>()
                .BuildServiceProvider();

            // get cloudinaryservice object
            var cloudinaryService = serviceProvider.GetService<ICloudinaryService>();
            // get list of artifacts
            var list = await cloudinaryService.GetListAsync();
            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}
