using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;

namespace EcommerceProject.ViewModels
{
    public class ViewModel_User
    {
        public int id { get; set; }
        public string Type { get; set; }
        public List<Customer> Customers { get; set; }

    }
}
