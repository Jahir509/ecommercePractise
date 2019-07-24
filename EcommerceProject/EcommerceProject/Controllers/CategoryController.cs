using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EcommerceProject.Controllers
{
    public class CategoryController : Controller
    {
        [HttpGet]
        public IActionResult ViewCategories()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Category category)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Category category)
        {
            return View();
        }
    }
}