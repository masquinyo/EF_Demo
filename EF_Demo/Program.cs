
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using EF_Demo.Context;
using Microsoft.Extensions.Hosting;
using System.Linq;

namespace EF_Demo
{
    class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            var options = new Microsoft.EntityFrameworkCore.DbContextOptions<DemoContext>();

            DemoContext context = new DemoContext(options);

            var customer = context.Customers.Where(c => c.Name == "Emmanuel Toledo").FirstOrDefault();
            System.Console.ForegroundColor = System.ConsoleColor.Cyan;
            System.Console.WriteLine($"Found customer {customer.Name}");

            //Lazy Loading...
            System.Console.WriteLine("with the following orders:");
            foreach (var order in customer.Orders)
            {
                System.Console.WriteLine($"Order {order.Number} with a total charge amount ${order.ChargeAmount}");
                System.Console.WriteLine("-- Products bought --");
                int count = 0;
                foreach (var orderProduct in order.OrderProducts)
                {
                    count++;
                    System.Console.WriteLine($"{count}. {orderProduct.Product.Name} costing ${orderProduct.Product.Cost}");
                }
            }

            System.Console.ReadLine();
        }


        //public static Microsoft.Extensions.Hosting.IHostBuilder CreateHostBuilder(string[] args)
        //=> Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
        //    .ConfigureServices(
        //      services  => services.AddDbContext<DemoContext>());
    }
}
