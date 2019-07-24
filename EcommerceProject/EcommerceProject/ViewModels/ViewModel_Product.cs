using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;

namespace EcommerceProject.ViewModels
{
    public class ViewModel_Product
    {

        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        public string Description { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        [Display(Name = "Category")]
        public int? CategoryId { get; set; }

        //public List<Shop> Shops { get; set; }
        //public List<OrderDetail> Orders { get; set; }
        public Category Category { get; set; }

        public List<SelectListItem> CategoryListItems { get; set; }
        public ICollection<global::Models.Product> ProductList { get; set; }
    }
}
