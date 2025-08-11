using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using mascotaedu.Models;

namespace mascotaedu.Controllers
{
    public class PetsController : Controller
    {
        // Lista estática para simular base de datos
        private static List<Pet> pets = new List<Pet>();
        private static int nextId = 1;

        public IActionResult Index()
        {
            return View(pets);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pet pet)
        {
            if (ModelState.IsValid)
            {
                pet.Id = nextId++;
                pet.CreatedAt = DateTime.UtcNow;
                pets.Add(pet);
                return RedirectToAction(nameof(Index));
            }
            return View(pet);
        }

        public IActionResult Details(int id)
        {
            var pet = pets.FirstOrDefault(p => p.Id == id);
            if (pet == null) return NotFound();
            return View(pet);
        }
    }
}

