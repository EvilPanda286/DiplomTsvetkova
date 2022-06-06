﻿using DiplomTsvetkova.Models;
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
                .ToList();

            var storagesSorted = storagesFromDb.OrderBy(s => s.Products.Count);

            var storages = storagesSorted
                .Where(s => s.Products.Count == storagesSorted.Last().Products.Count)
                .ToList();

            var storage = storages
                .OrderBy(s => s.Latitude + s.Longitude)
                .Last();

            return View(storage);
        }

    }
}