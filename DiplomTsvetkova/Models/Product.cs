using System.ComponentModel.DataAnnotations;

namespace DiplomTsvetkova.Models
{
    public class Product
    {
        [Key] public Guid Id { get; set; } = Guid.NewGuid();  // ID товара
        [Required] public string Name { get; set; } // название товара
        [Required] public decimal Price { get; set; } // цена
        [Required] public string Image { get; set; }
        public List<Storage> Storages { get; set; }
        public List<ProductStorage> ProductStorages { get; set; }
    }
}
