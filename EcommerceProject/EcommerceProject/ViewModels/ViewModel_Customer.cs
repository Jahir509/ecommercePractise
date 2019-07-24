using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;

namespace EcommerceProject.ViewModels
{
    public class ViewModel_Customer
    {
        public string Id { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string ContactNo { get; set; }
        public IFormFile PhotoFile { get; set; }
        [Required]
        [Display(Name = "Customer Type")]
        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }

        public List<SelectListItem> UserTypeList { get; set; }
    }
}
