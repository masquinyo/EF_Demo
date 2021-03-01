
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using EF_Demo.Context;
using Microsoft.Extensions.Hosting;

namespace EF_Demo
{
    class Program
    {
        public static void Main(string[] args)
       => CreateHostBuilder(args).Build().Run();


        public static Microsoft.Extensions.Hosting.IHostBuilder CreateHostBuilder(string[] args)
        => Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
            .ConfigureServices(
              services  => services.AddDbContext<DemoContext>());
    }
}
