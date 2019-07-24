using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL;
using BLL.Contracts;
using EcommerceProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;

namespace EcommerceProject.Controllers
{
    public class ProductController : Controller
    {
        private IMapper _mapper;
        private IProductManager _productManager;
        private ICategoryManager _categoryManager;

        public ProductController(IProductManager productManager,ICategoryManager categoryManager,IMapper mapper)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ViewProducts()
        {
            var products = _productManager.GetAll();
            var productListItem = _mapper.Map<IEnumerable<ViewModel_Product>>(products);
            return View(productListItem);
        }
        [HttpGet]
        public IActionResult Add()
        {
            List<SelectListItem> categoryListItems = _categoryManager.GetAll().Select(c => new SelectListItem()
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();
            var model = new ViewModel_Product();
           // ViewBag.CategoryItem = categoryListItems;
           model.CategoryListItems = categoryListItems;
           model.ProductList = _productManager.GetAll();
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(ViewModel_Product model)
        {
            try
            {
                var product = _mapper.Map<Product>(model);
                if (ModelState.IsValid)
                {
                   bool isAdded = _productManager.Add(product);
                   if (isAdded)
                   {
                       return RedirectToAction(nameof(ViewProducts));
                   }
                }

                return View();
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            return View();
        }
    }
}