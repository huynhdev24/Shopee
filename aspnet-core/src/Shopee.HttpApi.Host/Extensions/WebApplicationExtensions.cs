using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shopee.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Shopee.Extensions
{
    public static class WebApplicationExtensions
    {
        public static async Task<WebApplication> UseSeeder(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var applicationDbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                await ShopeeDbContextSeeder.SeedAsync(applicationDbContext);
            }

            return app;
        }

        public static WebApplication UseCustomCors(this WebApplication app)
        {
            app.UseCors("_localorigin");

            return app;
        }
    }
}
