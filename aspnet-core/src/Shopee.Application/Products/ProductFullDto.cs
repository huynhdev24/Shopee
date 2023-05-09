using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Shopee.Products
{
    public class ProductFullDto : EntityDto<Guid>
    {
        public string Brand { get; init; }
        public string Model { get; init; }
        public string Color { get; init; }
        public string Gender { get; init; }
        public string ImageBase { get; init; }
        public decimal Price { get; init; }
        public ICollection<ProductVariantDto> Variants { get; init; }
    }
}
