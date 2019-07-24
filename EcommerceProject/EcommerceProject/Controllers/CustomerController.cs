using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL;
using BLL.Contracts;
using EcommerceProject.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;

namespace EcommerceProject.Controllers
{
    public class CustomerController : Controller
    {
        private IMapper _mapper;
        private IHostingEnvironment _hostingEnvironment;
        private ICustomerManager _customerManager;
        private IUserManager _userManager;

        /****************************** CONSTRUCTOR *****************************/

        public CustomerController(ICustomerManager customerManager, IUserManager userManager, IMapper mapper,IHostingEnvironment hostingEnvironment)
        {
            _customerManager = customerManager;
            _userManager = userManager;
            _mapper = mapper;
            _hostingEnvironment = hostingEnvironment;
        }
        /****************************** VIEW CUSTOMER DETAILS *****************************/

        [HttpGet]
        public IActionResult ViewCustomer()
        {
            var customers = _customerManager.GetAll();
            var customerList = _mapper.Map<IEnumerable<ViewModel_Customer>>(customers);
            return View(customerList);
        }
        /****************************** END VIEW CUSTOMER DETAILS ************************/

        /****************************** CREATE *****************************/
        [HttpGet]
        public IActionResult Create()
        {
            List<SelectListItem> useListItems = _userManager.GetAll().Select(c => new SelectListItem()
            {
                Value = c.id.ToString(),
                Text = c.Type

            }).ToList();
            var model = new ViewModel_Customer();
            model.UserTypeList = useListItems;
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(ViewModel_Customer model)
        {
            try
            {
                
                if (ModelState.IsValid)
                {
                    string uniqueFileName = null;
                    if (model.PhotoFile != null)
                    {
                        string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                        uniqueFileName = Guid.NewGuid() + "_" + model.PhotoFile.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        model.PhotoFile.CopyTo(new FileStream(filePath,FileMode.Create));
                        
                    }

                    Customer customer = new Customer()
                    {
                        CustomerName = model.CustomerName,
                        Address = model.Address,
                        ContactNo = model.ContactNo,
                        Photo = uniqueFileName,
                        UserType = model.UserType
                    };
                    bool isAdded = _customerManager.Add(customer);
                   
                    {
                        return RedirectToAction("Details", new {id = customer.Id});
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }



        }
        /****************************** END CREATE ************************/

        /****************************** EDIT *****************************/
        [HttpGet]
        public IActionResult Edit(int id)
        {
            List<SelectListItem> userTypeList = _userManager.GetAll().Select(c => new SelectListItem()
            {
                Value = c.id.ToString(),
                Text = c.Type
            }).ToList();

            var model = new ViewModel_Customer();
            model = _mapper.Map<ViewModel_Customer>(_customerManager.GetById(id));
            model.UserTypeList = userTypeList;
            //var model = _mapper.Map<IEnumerable<ViewModel_Customer>>(customerInfo);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            return View();
        }
        /****************************** END EDIT ************************/

        /****************************** VIEW INDIVIDUAL DETAILS ************************/
        public IActionResult Details(int id)
        {
            List<SelectListItem> userTypeList = _userManager.GetAll().Select(c => new SelectListItem()
            {
                Value = c.id.ToString(),
                Text = c.Type
            }).ToList();

            var customerInfo = new Customer();
            customerInfo = _customerManager.GetById(id);
            customerInfo.UserTypeList = userTypeList;
            return View(customerInfo);
        }

        /**************************** END VIEW INDIVIDUAL DETAILS **********************/
    }
}   
