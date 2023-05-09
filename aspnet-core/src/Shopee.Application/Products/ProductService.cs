using Mapster;
using Shopee.Entities.Aggregates.ProductAggregate;
using Shopee.Interfaces;
using Shopee.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Products
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;
        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ICollection<ProductDTO>> GetProductsAsync()
        {
            var products = await _productRepository.ListAsync();

            return products.Adapt<ICollection<ProductDTO>>();
        }

        public async Task<ProductFullDTO> GetProductWithColorVariantsByIdAsync(int productId)
        {
            var spec = new ProductWithColorVariantsByIdSpec(productId);
            var product = await _productRepository.FirstOrDefaultAsync(spec);

            if (product is null)
            {
                throw new Exception(productId.ToString());
            }

            return product.Adapt<ProductFullDTO>();
        }

        public async Task<ICollection<ProductDTO>> GetProductsPagedAsync(int page, int pageSize, string gender)
        {
            var spec = new ProductsPagedSpec(page, pageSize, gender);
            var products = await _productRepository.ListAsync(spec);

            return products.Adapt<ICollection<ProductDTO>>();
        }

        public async Task<ICollection<ProductDTO>> GetFeaturedProductsAsync()
        {
            var spec = new FeaturedProductsSpec();
            var products = await _productRepository.ListAsync(spec);

            return products.Adapt<ICollection<ProductDTO>>();
        }

        public async Task<int> GetProductsCountByGenderAsync(string gender)
        {
            var spec = new ProductsCountByGenderSpec(gender);

            return await _productRepository.CountAsync(spec);
        }
    }
}
