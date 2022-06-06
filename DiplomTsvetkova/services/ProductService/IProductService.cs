using DiplomTsvetkova.Models;

namespace DiplomTsvetkova.services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
    }
}
