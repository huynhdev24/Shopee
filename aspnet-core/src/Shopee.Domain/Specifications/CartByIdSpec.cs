using Ardalis.Specification;
using Shopee.Entities.Aggregates.CartAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Shopee.Specifications
{
    public class CartByIdSpec : Specification<Cart>
    {
        public CartByIdSpec(string cartId)
        {
            Query
                .Include(cart => cart.Items)
                .Where(cart => cart.Id == cartId);
        }
    }
}
