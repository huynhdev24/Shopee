using Shopee.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Shopee;

[DependsOn(
    typeof(ShopeeEntityFrameworkCoreTestModule)
    )]
public class ShopeeDomainTestModule : AbpModule
{

}
