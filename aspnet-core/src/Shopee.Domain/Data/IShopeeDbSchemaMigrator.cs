using System.Threading.Tasks;

namespace Shopee.Data;

public interface IShopeeDbSchemaMigrator
{
    Task MigrateAsync();
}
