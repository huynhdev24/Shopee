using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Entities.Aggregates.ProductAggregate
{
    public class ProductVariant
    {
        private ProductVariant() { }

        public ProductVariant(int productId, int colorId)
        {
            Guard.Against.NegativeOrZero(productId, nameof(productId));
            Guard.Against.NegativeOrZero(colorId, nameof(colorId));

            ProductId = productId;
            ColorId = colorId;
        }
        public int ProductId { get; private set; }
        public Product Product { get; private set; }
        public int ColorId { get; private set; }
        public Color Color { get; private set; }
    }
}
