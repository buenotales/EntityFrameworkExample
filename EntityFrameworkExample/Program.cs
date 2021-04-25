using EntityFrameworkExample.Library.Data.Contexts;
using EntityFrameworkExample.Library.Data.Repositories;
using EntityFrameworkExample.Library.Data.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace EntityFrameworkExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();

            using (IServiceScope serviceScope = host.Services.CreateScope())
            {
                IServiceProvider provider = serviceScope.ServiceProvider;

                provider.GetRequiredService<App>().Execute();
            }

            host.Run();
        }
        static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                {
                    services.AddTransient<App, App>();
                    services.AddTransient<IProductRepository, ProductRepository>();
                    services.AddTransient<ISaleRepository, SaleRepository>();
                    services.AddTransient<IPromotionRepository, PromotionRepository>();
                    services.AddTransient<EFContext, EFContext>();
                });
        }
    }
}
