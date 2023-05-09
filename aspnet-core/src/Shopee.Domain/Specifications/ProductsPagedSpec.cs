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
    public class ProductsPagedSpec : Specification<Product>
    {
        public ProductsPagedSpec(int page, int pageSize, string gender)
        {
            Query
                .Where(product => product.Gender == gender)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }
    }
}
