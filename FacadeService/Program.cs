using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace FacadeService
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseSetting(WebHostDefaults.DetailedErrorsKey, "true")
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}