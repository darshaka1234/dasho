﻿using dasho.Data;
using dasho.Models;
using Microsoft.AspNetCore.Mvc;

namespace dasho.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if(ModelState.IsValid) { 
            _db.Categories.Add(obj);
            _db.SaveChanges();
                return RedirectToAction("Index");
            }
           return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0) { 
            return NotFound();
            }

            Category? category = _db.Categories.FirstOrDefault(c => c.Id == id);
            if(category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? category = _db.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            _db.Categories.Remove(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            
        }
    }
}