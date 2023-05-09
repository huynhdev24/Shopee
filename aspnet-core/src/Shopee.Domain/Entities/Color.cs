using Ardalis.GuardClauses;
using Shopee.Entities.Aggregates.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Entities
{
    public class Color : BaseEntity<int>
    {
        private Color() { }

        public Color(int id, string name)
        {
            Guard.Against.NegativeOrZero(id, nameof(id));
            Guard.Against.NullOrWhiteSpace(name, nameof(name));

            Id = id;
            Name = name;
        }

        public string Name { get; private set; }
        public ICollection<ProductVariant> ProductVariants { get; private set; }
    }
}
