using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Shopee;

[Dependency(ReplaceServices = true)]
public class ShopeeBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Shopee";
}
