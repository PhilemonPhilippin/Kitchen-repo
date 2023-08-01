using Kitchen.Dal.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace KitchenIntegrationTests.Tools;


public class WebApplicationFactoryKitchenTest<TProgram>
: WebApplicationFactory<TProgram> where TProgram : class
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {
            var dbContextDescriptor = services.SingleOrDefault(
                d => d.ServiceType ==
                    typeof(DbContextOptions<KitchenContext>));

            services.Remove(dbContextDescriptor);

            var dbConnectionDescriptor = services.SingleOrDefault(
                d => d.ServiceType ==
                    typeof(DbConnection));

            services.Remove(dbConnectionDescriptor);

            string kitchenTestConnectionString = Environment.GetEnvironmentVariable("KitchenTestConnectionString", EnvironmentVariableTarget.User) ?? "Environment variable for KitchenTest not found.";
            services.AddDbContext<KitchenContext>(options => options.UseSqlServer(kitchenTestConnectionString));
        });

        builder.UseEnvironment("Development");
    }
}
