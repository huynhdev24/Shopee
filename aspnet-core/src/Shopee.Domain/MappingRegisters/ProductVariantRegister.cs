using Mapster;
using Shopee.Entities.Aggregates.ProductAggregate;
using Shopee.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.MappingRegisters
{
    public class ProductVariantRegister : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<ProductVariant, ProductVariantDTO>()
                .Map(dest => dest.Name, src => src.Color.Name);
        }
    }
}
