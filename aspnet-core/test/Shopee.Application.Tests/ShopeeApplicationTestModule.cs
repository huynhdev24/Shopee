using Volo.Abp.Modularity;

namespace Shopee;

[DependsOn(
    typeof(ShopeeApplicationModule),
    typeof(ShopeeDomainTestModule)
    )]
public class ShopeeApplicationTestModule : AbpModule
{

}
