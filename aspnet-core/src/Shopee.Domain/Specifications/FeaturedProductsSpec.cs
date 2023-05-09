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
    public class FeaturedProductsSpec : Specification<Product>
    {
        public FeaturedProductsSpec()
        {
            Query
                .OrderBy(p => Guid.NewGuid())
                .Take(4);
        }
    }
}
