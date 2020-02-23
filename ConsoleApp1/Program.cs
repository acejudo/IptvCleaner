using IptvCleaner.Services;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace IptvCleaner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string INPUT_FILE = Directory.GetCurrentDirectory().ToString() + @"/m3u.txt";
            string OUTPUT_FILE = Directory.GetCurrentDirectory() + @"/output.txt";

            // setup our serviceProvider
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IServiceCleaner, ServiceCleaner>()
                .BuildServiceProvider();

            // get service
            var cleanerIptvFile = serviceProvider.GetService<IServiceCleaner>();

            // run cleaner
            cleanerIptvFile.CleanIptvFile(INPUT_FILE, OUTPUT_FILE);
        }
    }
}
