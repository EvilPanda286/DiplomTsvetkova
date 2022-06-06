using System.ComponentModel.DataAnnotations;

namespace DiplomTsvetkova.Models
{
    public class RegistrationVm
    {
        [Required] public string UserName { get; set; } // Юзернейм
        [Required] public string Password { get; set; } // Пароль
        [Required] public string Name { get; set; } // Имя клиента
        [Required] public string Surname { get; set; } // Фамилия клиента
        [Required] public string Patronymic { get; set; } // Отчество клиента
        [Required] public string NumberPhone { get; set; } // Номер телефона клиента
        [Required] public string Address { get; set; } // адрес клиента
        [Required] public double Latitude { get; set; }  //x
        [Required] public double Longitude { get; set; } //y
    }
}