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
           // var ss = db.ProductStorages.GroupBy(ps => ps.StorageId).Select(k=>k.Key).Count();

            //var res = db.ProductStorages.Include(p=>p.Product).Include(prop=>prop.Storage).Where(ps=> _productService.Products.Contains(ps.Product)).ToList().GroupBy(ps => ps.StorageId).Select(g => new {StorageName = g.Key, Count = g.Select(s=>s) });

            //var ress = db.ProductStorages.Where(ps => _productService.Products.Contains(ps.Product)).ToList().GroupBy(ps => ps.StorageId).Count();

            //var xy = db.ProductStorages.Where(s => _productService.Products.Contains(s.Product)).Select(s=> s.Storage).ToList();

            //var xxy = xy.GroupBy(ps => ps.Id).Select(g => new { StorageName = g.Key, Count = g, Data= g.Select(p=>p) });

            var rr1 = db.Storages.Include(s => s.Products).Select(s => s.Products.Where(p => _productService.Products.Contains(p))).ToList();

            var r2r = db.Products.Include(s => s.Storages).Select(s => _productService.Products.Contains(p)).ToList();

            
            
            return View();
        }

    }
}