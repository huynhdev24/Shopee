using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Shopee.Products
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Gender { get; set; }
        public string ImageBase { get; set; }
        public decimal Price { get; set; }
    }
}
