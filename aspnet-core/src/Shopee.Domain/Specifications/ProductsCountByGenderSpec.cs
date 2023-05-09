using Shopee.Entities.Aggregates.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Shopee.Specifications
{
    public class ProductsCountByGenderSpec : Specification<Product>
    {
        public ProductsCountByGenderSpec(string gender)
        {
            Query
                .Where(product => product.Gender == gender);
        }
    }
}
