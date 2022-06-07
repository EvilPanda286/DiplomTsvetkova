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
            var productsService = _productService.Products;
            List<Storage> coolStorages = new();

            while (productsService.Count != 0)
            {
                var storage = GetCoolStorage(productsService);
                var tmp = new List<Product>(productsService);
                var productsForStorage = new List<Product>();

                foreach (var product in tmp)
                {
                    if (storage.Products.Any(p => p.Id == product.Id))
                    {
                        productsService.Remove(product);
                        productsForStorage.Add(product);
                    }
                }
                storage.Products = productsForStorage;
                var PS = storage.ProductStorages.Where(x => productsForStorage.Contains(x.Product));
                storage.ProductStorages = new List<ProductStorage>(PS);

                coolStorages.Add(storage);

            }

            return View(coolStorages);
        }

        [HttpPost]
        public async Task<IActionResult> CartList(List<Storage> storages)
        {
            var orders = new List<Order>();
            foreach(var storage in storages)
            {
                foreach (var pr in storage.ProductStorages)
                {
                    var order = new Order()
                    {
                        Client = db.Clients.First(c => c.UserName == _authenticationService.UserName),
                        Quatity = 1,
                        ProductStorage = pr
                    };
                    orders.Add(order);
                }
                
            }
            await db.Orders.AddRangeAsync(orders);
            await db.SaveChangesAsync();

            return View(orders);
        }


        private Storage GetCoolStorage(List<Product> products)
        {
            List<Storage> storagesFromDb = new();

            foreach (var p in products)
            {
                var st = db.Storages.Where(s => s.Products.Contains(p))
              .Include(s => s.Products)
              .ToList();

                storagesFromDb.AddRange(st);
            }

            storagesFromDb.GroupBy(x => x.Id).Select(x => x.First()).ToList();

            var storagesSorted = storagesFromDb.OrderBy(s => s.Products.Count);

            var storages = storagesSorted
                .Where(s => s.Products.Count == storagesSorted.Last().Products.Count)
                .ToList();

            var storage = storages
                .OrderBy(s => s.Latitude + s.Longitude)
                .Last();

            return storage;
        }
    }
}