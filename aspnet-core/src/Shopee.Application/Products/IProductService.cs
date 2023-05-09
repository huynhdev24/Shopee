using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Products
{
    public interface IProductService
    {
        Task<ICollection<ProductDTO>> GetProductsAsync();
        Task<ICollection<ProductDTO>> GetProductsPagedAsync(int page, int pageSize, string gender);
        Task<ProductFullDTO> GetProductWithColorVariantsByIdAsync(int productId);
        Task<ICollection<ProductDTO>> GetFeaturedProductsAsync();
        Task<int> GetProductsCountByGenderAsync(string gender);
    }
}
