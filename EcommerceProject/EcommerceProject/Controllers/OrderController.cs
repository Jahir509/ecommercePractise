using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Contracts;
using EcommerceProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EcommerceProject.Controllers
{
    public class OrderController : Controller
    {
        private IProductManager _productManager;

        public OrderController(IProductManager productManager)
        {
            _productManager = productManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            var productList = _productManager.GetAll().Select(c => new SelectListItem()
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();

            var model = new ViewModel_Order()
            {
                ProducListItems = productList
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(ViewModel_Order model)
        {
            return View();
        }
    }
}