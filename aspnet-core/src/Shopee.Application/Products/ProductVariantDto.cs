using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Shopee.Products
{
    public class ProductVariantDto : EntityDto<Guid>
    {
        public string Name { get; init; }
    }
}
