using System.ComponentModel.DataAnnotations;

namespace DiplomTsvetkova.Models
{
    public class Order
    {
        [Key] public Guid Id { get; set; } = Guid.NewGuid();  // Id заказа
        [Required] public Guid ProductStorageId { get; set; } // Id товара
        [Required] public int Quatity { get; set; } // Количество заказанного товара
        [Required] public Guid ClientId { get; set; } // Id клиента
        [Required] public Client Client { get; set; }
        [Required] public ProductStorage ProductStorage { get; set; }
    }
}
