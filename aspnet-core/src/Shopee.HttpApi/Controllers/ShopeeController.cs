using Shopee.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Shopee.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ShopeeController : AbpControllerBase
{
    protected ShopeeController()
    {
        LocalizationResource = typeof(ShopeeResource);
    }
}
