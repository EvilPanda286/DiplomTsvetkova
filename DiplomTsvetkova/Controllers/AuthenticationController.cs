using DiplomTsvetkova.Models;
using DiplomTsvetkova.services.AuthenticationService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DiplomTsvetkova.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DiplomTsvetkovaContext _db;
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(
            ILogger<HomeController> logger,
         DiplomTsvetkovaContext diplom,
         IAuthenticationService authenticationService
         )
        {
            _logger = logger;
            _db = diplom;
            _authenticationService = authenticationService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult<string>> Login(string userName, string password)
        {
            var client = _db.Clients.FirstOrDefault(u => u.Name == userName);

            if(client == null)
            {
                return BadRequest("Пользователь не найден.");
            }

            if (!client.Password.Equals(password))
            {
                return BadRequest("Пароль не верен.");
            }
            _authenticationService.UserName = userName;
            _authenticationService.Password = password;
            ViewBag.Message = "Banan";
            return Redirect("~/Home/Index");
        }

        [HttpPost]
        public async Task<ActionResult<string>> Register(RegistrationVm registrationVm)
        {
            if(await _db.Clients.AnyAsync(u=>u.UserName == registrationVm.UserName))
            {
                return BadRequest("Пользователь с таким UserName уже существует.");
            }

            var client = new Client()
            {
                UserName = registrationVm.UserName,
                Password = registrationVm.Password,
                Name = registrationVm.Name,
                Surname = registrationVm.Surname,
                Patronymic = registrationVm.Patronymic,
                Address = registrationVm.Address,
                NumberPhone = registrationVm.NumberPhone,
                Latitude = registrationVm.Latitude,
                Longitude = registrationVm.Longitude
            };
            await _db.Clients.AddAsync(client);
            await _db.SaveChangesAsync();
            return Ok(client.UserName);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}