using System;
using System.Collections.Generic;
using System.Text;

namespace Shopee.Products
{
    public class CartDTO
    {
        public string Id { get; set; }
        public ICollection<CartItemDTO> Items { get; set; }
    }
}
