using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiplomTsvetkova.Models
{
    
    public class ProductStorage
    {
        [Key] public Guid Id { get; set; } = Guid.NewGuid();  // ID товара на складе
        [Required] public int Quantity { get; set; } // Количество товара на складе
        [Required] public Guid ProductId { get; set; } // ID товара
        [Required] public Product Product { get; set; }
        [Required] public Guid StorageId { get; set; } // ID склада
        [Required] public Storage Storage { get; set; }
        public List<Order> Orders { get; set; }
    }
}
