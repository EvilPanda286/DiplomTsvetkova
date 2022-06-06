using System.ComponentModel.DataAnnotations;

namespace DiplomTsvetkova.Models
{
    public class Storage
    {
        [Key] public Guid Id { get; set; } = Guid.NewGuid(); // ID склада
        [Required] public string Name { get; set; } // название склада
        [Required] public string Address { get; set; } // адрес склада
        [Required] public double Latitude { get; set; }  //x
        [Required] public double Longitude { get; set; } //y
        public List<Product> Products { get; set; }
        public List<ProductStorage> ProductStorages { get; set; }
    }
}
