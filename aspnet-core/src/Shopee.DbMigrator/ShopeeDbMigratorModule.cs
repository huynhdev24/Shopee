using Shopee.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Shopee.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ShopeeEntityFrameworkCoreModule),
    typeof(ShopeeApplicationContractsModule)
    )]
public class ShopeeDbMigratorModule : AbpModule
{

}
