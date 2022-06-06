using DiplomTsvetkova.Models;

namespace DiplomTsvetkova.services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
