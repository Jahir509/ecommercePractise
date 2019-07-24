using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string Photo { get; set; }
        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }
        [NotMapped]
        public List<SelectListItem> UserTypeList { get; set; }
    }
}
