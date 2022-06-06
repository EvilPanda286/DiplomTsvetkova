using DiplomTsvetkova.Models;
using DiplomTsvetkova.services.AuthenticationService;
using DiplomTsvetkova.services.ProductService;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DiplomTsvetkova.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DiplomTsvetkovaContext diplom;
        private readonly IAuthenticationService _authenticationService;
        private readonly IProductService _productService;
        public HomeController(
            ILogger<HomeController> logger,
         DiplomTsvetkovaContext diplom,
          IAuthenticationService authenticationService,
          IProductService productService)
        {
            _logger = logger;
            this.diplom = diplom;
            _authenticationService = authenticationService;
            _productService = productService;
        }
      
        public IActionResult Index()
        {
            if (!_authenticationService.AuthentiocationState())
            {
                return Unauthorized();
            }
            var products = diplom.Products.ToList();
            ViewData["products"] = products[0];
            return View(products);
        }

        public IActionResult AddToCart(Product product)
        {
            if(_productService.Products.Any(p=>p.Id == product.Id))
            {
                //_productService.Products.(p => p.Id == product.Id).Q;
            }
            _productService.Products.Add(product);
            return Redirect("~/Home/Index");
        }

        public IActionResult Privacy()
        {
            if (!_authenticationService.AuthentiocationState())
            {
                return Unauthorized();
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}