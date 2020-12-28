using Infrastructure.Cloudinary;
using System;
using System.Threading.Tasks;

namespace CloudnaryClient.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var service = new CloudinaryService();
            var list = await service.GetListAsync();
            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}
