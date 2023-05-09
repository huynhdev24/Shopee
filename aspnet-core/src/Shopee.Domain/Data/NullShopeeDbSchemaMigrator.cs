using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Shopee.Data;

/* This is used if database provider does't define
 * IShopeeDbSchemaMigrator implementation.
 */
public class NullShopeeDbSchemaMigrator : IShopeeDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
