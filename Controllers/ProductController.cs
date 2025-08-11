using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using mascotaedu.Models;

namespace mascotaedu.Controllers
{
    public class ProductsController : Controller
    {
        // Lista estática para simular base de datos
        private static List<Product> products = new List<Product>();
        private static int nextId = 1;

        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                product.Id = nextId++;
                products.Add(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return View(product);
        }
    }
}
