using System;
using System.Collections.Generic;
using System.Text;
using Shopee.Localization;
using Volo.Abp.Application.Services;

namespace Shopee;

/* Inherit your application services from this class.
 */
public abstract class ShopeeAppService : ApplicationService
{
    protected ShopeeAppService()
    {
        LocalizationResource = typeof(ShopeeResource);
    }
}
