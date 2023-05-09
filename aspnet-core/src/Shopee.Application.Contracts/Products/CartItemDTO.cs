using System;
using System.Collections.Generic;
using System.Text;

namespace Shopee.Products
{
    public class CartItemDTO
    {
        public string Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
    }
}
