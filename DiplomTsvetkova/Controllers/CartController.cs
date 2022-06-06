using DiplomTsvetkova.Models;
using DiplomTsvetkova.services.AuthenticationService;
using DiplomTsvetkova.services.ProductService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DiplomTsvetkova.Controllers
{
    public class CartController : Controller
    {
        private readonly DiplomTsvetkovaContext db;
        private readonly IAuthenticationService _authenticationService;
        private readonly IProductService _productService;

        public CartController(
            DiplomTsvetkovaContext db,
            IAuthenticationService authenticationService,
            IProductService productService
           )
        {
            this.db = db;
            _authenticationService = authenticationService;
            _productService = productService;
        }

        public async Task<IActionResult> CartList()
        {
            var storagesFromDb = db.Storages
                .Include(s => s.Products
                .Where(s => _productService.Products.Contains(s)))
                .OrderBy(s => s.Products.Count)
                .ToList();


            var storages = storagesFromDb.Where(s => s.Products.Count == storagesFromDb.Last().Products.Count).ToList();

            //var xy = db.ProductStorages.Where(s => _productService.Products.Contains(s.Product)).Select(s=> s.Storage).ToList();

            //var xxy = xy.GroupBy(ps => ps.Id).Select(g => new { StorageName = g.Key, Count = g, Data= g.Select(p=>p) });

            var rr1 = db.Storages.Include(s => s.Products).Select(s => s.Products.Where(p => _productService.Products.Contains(p))).ToList();

           // var r2r = db.Products.Include(s => s.Storages).Select(s => _productService.Products.Contains(p)).ToList();

            
            
            return View();
        }

    }
}