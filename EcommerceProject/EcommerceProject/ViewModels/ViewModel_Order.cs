using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;

namespace EcommerceProject.ViewModels
{
    public class ViewModel_Order
    {
        public string OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<SelectListItem> ProducListItems { get; set; }
        public List<SelectListItem> CustomerListItems { get; set; }

    }
}
