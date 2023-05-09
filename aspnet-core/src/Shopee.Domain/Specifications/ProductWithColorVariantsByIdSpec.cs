using Ardalis.Specification;
using Shopee.Entities.Aggregates.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Shopee.Specifications
{
    public class ProductWithColorVariantsByIdSpec : Specification<Product>, ISingleResultSpecification<Product>
    {
        public ProductWithColorVariantsByIdSpec(int productId)
        {
            Query
                .Include(product => product.Variants)
                .ThenInclude(colorVariants => colorVariants.Color)
                .Where(product => product.Id == productId);
        }
    }
}
